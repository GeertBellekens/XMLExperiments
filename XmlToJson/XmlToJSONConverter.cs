using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;

namespace XmlToJson
{
    internal class XmlToJSONConverter
    {
        public static string ConvertXmlToJsonFile(string xmlPath)
        {
            //convert XML to JSON string
            string jsonContent = ConvertXmlToJson(xmlPath);

            //create output path with .json extension
            string jsonPath = Path.ChangeExtension(xmlPath, ".json");

            //save to file
            File.WriteAllText(jsonPath, jsonContent);

            return jsonPath;
        }

        public static string ConvertXmlToJson(string xmlPath)
        {
            //read the xml file into an XDocument
            var xmlDoc = XDocument.Load(xmlPath);

            //create new JSON document object
            var jsonDoc = new JObject();

            //convert the root element
            if (xmlDoc.Root != null)
            {
                var rootObject = ConvertElement(xmlDoc.Root);
                jsonDoc.Add(xmlDoc.Root.Name.LocalName, rootObject);
            }

            //return formatted JSON string
            return jsonDoc.ToString(Newtonsoft.Json.Formatting.Indented);
        }

        private static JToken ConvertElement(XElement element)
        {
            //check if this element has child elements
            var childElements = element.Elements().ToList();

            if (childElements.Count == 0)
            {
                //leaf element - return the value
                if (string.IsNullOrEmpty(element.Value))
                {
                    return JValue.CreateNull();
                }
                return new JValue(element.Value);
            }

            //check if this is a "grouping" element (contains multiple children with same name)
            var groupedChildren = childElements.GroupBy(e => e.Name.LocalName).ToList();

            //if all children have the same name and there are multiple, treat as array
            if (groupedChildren.Count == 1 && childElements.Count > 1)
            {
                //this is a grouping element - create an array
                var array = new JArray();
                foreach (var child in childElements)
                {
                    array.Add(ConvertElement(child));
                }
                return array;
            }

            //otherwise, create an object with properties
            var obj = new JObject();
            foreach (var group in groupedChildren)
            {
                var childName = group.Key;
                var children = group.ToList();

                if (children.Count == 1)
                {
                    //single child - add as property
                    obj.Add(childName, ConvertElement(children[0]));
                }
                else
                {
                    //multiple children with same name - create array
                    var array = new JArray();
                    foreach (var child in children)
                    {
                        array.Add(ConvertElement(child));
                    }
                    obj.Add(childName, array);
                }
            }

            return obj;
        }
    }
}
