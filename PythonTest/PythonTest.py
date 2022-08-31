from xml.etree import cElementTree as ET
import datetime
import pyodbc

def processFile(xml_file_path, csvFile):
    print (datetime.datetime.now(), " ","start processing ", xml_file_path)
    i = 0
    with open(csvFile, "w") as the_file:
        
        for event, elem in ET.iterparse(xml_file_path, events=("start", "end")):
            if event == 'end' and elem.tag == "PP":
                ppNummer = elem.find("PP_NUMMER").text
                intKey = elem.find("PP_INTKEY").text
                elem.clear()
                csvLine = ppNummer + "," + intKey + "\n"
                the_file.write(csvLine)
                i = i + 1
    print (datetime.datetime.now(), " ", str(i), " records processed")

def inportPolicies(csvFile):
    connection = pyodbc.connect(driver="{SQL Server}",server="DESKTOP-BGN5EL4",database="TestXML")
    cursor = connection.cursor()
    cursor.execute("truncate table PP")
    print (datetime.datetime.now(), " Truncated table")
    cursor.execute("bulk insert PP from '" + csvFile +"' WITH ( FORMAT = 'CSV');")
    print (datetime.datetime.now(), " Bulk inserted data")

inputFile = "c:\\temp\\input.xml"
outputFile = "c:\\temp\\pythonDestination.csv"
processFile(inputFile, outputFile)
inportPolicies(outputFile)