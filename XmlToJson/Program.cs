using XmlToJson;

if (args.Length == 0)
{
    Console.WriteLine("Usage: XmlToJson <xmlFilePath>");
    Console.WriteLine("Example: XmlToJson c:\\data.xml");
    return 1;
}

string xmlPath = args[0];

if (!File.Exists(xmlPath))
{
    Console.WriteLine($"Error: File '{xmlPath}' not found.");
    return 1;
}

try
{
    string jsonPath = XmlToJSONConverter.ConvertXmlToJsonFile(xmlPath);
    Console.WriteLine($"Successfully converted '{xmlPath}' to '{jsonPath}'");
    return 0;
}
catch (Exception ex)
{
    Console.WriteLine($"Error converting file: {ex.Message}");
    return 1;
}
