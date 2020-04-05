using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            Encoding utf8 = Encoding.UTF8;
            StreamReader reader = new StreamReader("../../subs.txt", utf8);

            using (reader)
            {
                int lineNumber = 0;
                string line = reader.ReadLine();

                while(line != null)
                {
                    if(lineNumber%2==1)
                    {
                        Console.WriteLine(line);
                    }
                    lineNumber++;
                    line = reader.ReadLine();

                }
            }
        }
    }
}
