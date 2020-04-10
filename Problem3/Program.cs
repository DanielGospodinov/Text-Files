using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("../../text1.txt");
            List<string> lines = new List<string>();

            using (reader)
            {
                int lineNumber = 1;
                string line = reader.ReadLine();

                while(line != null )
                {
                    lines.Add(lineNumber+ " : " + line);
                    line = reader.ReadLine();
                    lineNumber++;
                }
            }

            StreamWriter writer = new StreamWriter("../../text2.txt");

            using (writer)
            {
                foreach (string value in lines)
                {
                    writer.WriteLine(value);
                }
            }
        }
    }
}
