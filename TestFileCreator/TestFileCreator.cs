using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFileCreator
{
    internal class TestFileCreator
    {
        public static string createTestFile(string startFile, string destinationFile, long repeats)
        {
            var feedback = new StringBuilder();
            feedback.AppendLine($"{DateTime.Now:dd/MM/yyyy hh:mm:ss.fff} Start creating testfile '{destinationFile}'");
            long j = 0;
            using (var destFileWriter = new System.IO.StreamWriter(destinationFile, false))
            {
                var atDestinationStart = true;
                var endline = string.Empty;
                
                for (int i = 0; i < repeats; i++)
                {
                    using (var startFileReader = System.IO.File.OpenText(startFile))
                    {
                        string currentline = null;
                        string previousLine = null;
                        var atSourceStart = true;
                        while ((currentline = startFileReader.ReadLine()) != null)
                        {
                            if ( atSourceStart)
                            {
                                if (atDestinationStart)
                                {
                                    //we are at the very first line, set it up to be written and set flag to false
                                    previousLine = currentline;
                                    atDestinationStart = false;
                                }
                                atSourceStart = false;
                            }
                            else
                            {
                                if (previousLine != null)
                                { 
                                    //write previous line
                                    destFileWriter.WriteLine(previousLine);
                                    j++;
                                }
                                //remember this line to be written
                                previousLine = currentline;
                                endline = currentline;
                            }
                        }
                    }
                 }
                //now write the very last line
                destFileWriter.WriteLine(endline);
                j++;
            }
            feedback.AppendLine($"{DateTime.Now:dd/MM/yyyy hh:mm:ss.fff} Finished creating testfile '{destinationFile}' with {j} lines");
            return feedback.ToString();
        }
    }
}
