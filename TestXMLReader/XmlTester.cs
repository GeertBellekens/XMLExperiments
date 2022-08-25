using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;
using System.Data.SqlClient;

namespace TestXMLReader
{
    internal class XmlTester
    {
        public static string importFullMemory(string fileName)
        {
            var returnValue = $"{DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss.fff")} Start reading '{fileName}'{Environment.NewLine}";
            var reader = XmlReader.Create(new System.IO.StreamReader(fileName,true));
            var xdoc = XDocument.Load(reader);
            int i = 0;
            foreach(var node in xdoc.Root.Elements())
            {
                i++;
                //do something with the node
                //returnValue += $"{System.DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss.fff")} found node: {i}{Environment.NewLine}";
            }
            returnValue +=  $"{DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss.fff")} Finished reading reading {i} nodes{Environment.NewLine}";
            return returnValue;
        }
        public string importStreaming (string fileName)
        {
            var feedback = new StringBuilder();
            feedback.AppendLine( $"{DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss.fff")} Start reading '{fileName}'");
            int i = 0;
            using (var connection = new SqlConnection(this.connectionString))
            {
                connection.Open();
                var truncateString = $"truncate table PP";
                var ddlCommand = new SqlCommand(truncateString, connection);
                ddlCommand.ExecuteNonQuery();
                using (XmlReader reader = XmlReader.Create(fileName))
                {
                    reader.MoveToContent();
                    while (reader.Read())
                    {
                        if (reader.NodeType == XmlNodeType.Element)
                        {
                            if (reader.Name == "PP")
                            {
                                XElement el = XNode.ReadFrom(reader) as XElement;
                                i++;
                                var insertString = $"INSERT INTO PP(PP_NUMMER, PP_INTKEY) VALUES('{el.Element("PP_NUMMER").Value}', '{el.Element("PP_INTKEY").Value}')";
                                ddlCommand = new SqlCommand(insertString, connection);
                                ddlCommand.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }
            feedback.AppendLine($"{DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss.fff")} Finished importing {i} nodes");
            return feedback.ToString();
            
        }
        public string importStreamingToFile(string fileName)
        {
            var csvFile = fileName + ".csv";
            var feedback = new StringBuilder();
            feedback.AppendLine($"{DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss.fff")} Start reading '{fileName}'");
            int i = 0;
            using (var logfile = new System.IO.StreamWriter(fileName + ".csv", true))
            {
                using (XmlReader reader = XmlReader.Create(fileName))
                {
                    reader.MoveToContent();
                    while (reader.Read())
                    {
                        if (reader.NodeType == XmlNodeType.Element)
                        {
                            if (reader.Name == "PP")
                            {
                                XElement el = XNode.ReadFrom(reader) as XElement;
                                i++;
                                logfile.WriteLine($"{el.Element("PP_NUMMER").Value},{el.Element("PP_INTKEY").Value}");

                            }
                        }
                    }
                }
                logfile.Close();
            }
            feedback.AppendLine($"{DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss.fff")} Finished writing logfile with {i} nodes");
            using (var connection = new SqlConnection(this.connectionString))
            {
                connection.Open();
                //clear table
                var truncateString = $"truncate table PP";
                var ddlCommand = new SqlCommand(truncateString, connection);
                ddlCommand.ExecuteNonQuery();
                //bulk insert
                var bulkInsertString = $"bulk insert PP from '{csvFile}' WITH ( FORMAT = 'CSV');";
                ddlCommand = new SqlCommand(bulkInsertString, connection);
                ddlCommand.ExecuteNonQuery();

            }
            feedback.AppendLine($"{DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss.fff")} Finished importing {i} nodes");
            return feedback.ToString();

        }




        private string connectionString
        {
            get
            {
                var builder = new SqlConnectionStringBuilder();
                builder["Server"] = "DESKTOP-BGN5EL4";
                builder["integrated Security"] = true;
                builder["Initial Catalog"] = "TestXML";
                return builder.ConnectionString;
            }
        }
        public string import(string fileName)
        {
            var errors = new StringBuilder();
            //var importTables = this.parseErx(fileName);
            //using (var connection = new SqlConnection(this.connectionString))
            //{
            //    connection.Open();
            //    foreach (var importTable in importTables)
            //    {
            //        //execute create table
            //        var ddlCommand = new SqlCommand(importTable.ddl, connection);
            //        try
            //        {
            //            ddlCommand.ExecuteNonQuery();
            //        }
            //        catch (Exception e)
            //        {
            //            if (!e.Message.Contains("There is already an object named"))
            //            {
            //                //skip this one
            //                errors.Append($"{Environment.NewLine}Error on ddl for table '{importTable.tableName}' {Environment.NewLine}{e.Message}"
            //                    + $"{Environment.NewLine}SQL Statement: {importTable.ddl}");
            //                continue;
            //            }
            //            //if the table already exists we don't care and we continue
            //        }

            //        //execute inserts
            //        if (!string.IsNullOrEmpty(importTable.imports))
            //        {

            //            var importcommand = new SqlCommand(importTable.imports, connection);
            //            //set timeout to 3 minutes to avoid timeout issues
            //            importcommand.CommandTimeout = 360;
            //            try
            //            {
            //                importcommand.ExecuteNonQuery();
            //            }
            //            catch (Exception e)
            //            {
            //                errors.Append($"{Environment.NewLine}Error on imports for table '{importTable.tableName}' {Environment.NewLine}{e.Message}"
            //                    + $"{Environment.NewLine}SQL Statement: {importTable.imports}");
            //            }
            //        }
            //    }
            //}
            return errors.ToString();
        }
    }
}
