using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class ReadFile
    {
        List<string> fileLines = new List<string>();
        List<string> fileLines2 = new List<string>();

        public void FileRead( String fileName)
        {

            bool start = true;
            bool provinces = false;

            using (var reader = new StreamReader(fileName)) {
                string line;
                while ((line = reader.ReadLine()) != null) {
                    if (line.Equals("countries={")) {
                        provinces = false;
                        fileLines.Add(line);
                    } else if (line.Equals("provinces={") || provinces == true) {
                        start = false;
                        provinces = true;
                        ProvinceCreation(LineBreake(line));

                        //Console.WriteLine(line);
                    } else if(start) {
                        fileLines.Add(line);
                    }
                    

                    
                }
                
            }
        }

            
        
    private List<string> LineBreake(string line)
    {
        List<string> lineStrings = new List<string>();
            if (line.Contains('=')) {
                int indexOfEqual = line.IndexOf('=');

                line.Substring(0, indexOfEqual);

                Console.WriteLine(line.Substring(0, indexOfEqual));
                Console.WriteLine(line.Substring(0, indexOfEqual));
            }
        return lineStrings;
    }

        
        private void ProvinceCreation(List<string> p)
        {
            
        }

        public List<string> getFileLines()
        {
            return fileLines;
        }
        public List<string> getFileLines2()
        {
            return fileLines2;
        }

    }
}
