using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using System.Xml;

namespace XSDCompare
{
    internal class XSDComparer
    {
        public void CompareXSD(string oldXSDPath,string newXSDPath)
        {
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            XmlSchema oldSchema = XmlSchema.Read(new XmlTextReader(oldXSDPath), ValidationCallback);
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
            var rootElement = oldSchema.Items.OfType<XmlSchemaElement>().FirstOrDefault();
            var rootType = oldSchema.Items.OfType<XmlSchemaType>().FirstOrDefault( x => x.Name == rootElement.SchemaTypeName.Name);

            XmlSchema newSchema = XmlSchema.Read(new XmlTextReader(newXSDPath), ValidationCallback);
        }
        static void ValidationCallback(object sender, ValidationEventArgs args)
        {
            if (args.Severity == XmlSeverityType.Warning)
                Console.Write("WARNING: ");
            else if (args.Severity == XmlSeverityType.Error)
                Console.Write("ERROR: ");

            Console.WriteLine(args.Message);
        }
    }
}
