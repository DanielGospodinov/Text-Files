using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader1 = new StreamReader("../../text1.txt");
            StreamReader reader2 = new StreamReader("../../text2.txt");
            int sameLines = 0, diffLines = 0;

            using (reader1)
            {
                using (reader2)
                {
                    string line1 = reader1.ReadLine();
                    string line2 = reader2.ReadLine();

                    while (line1 != null || line2 != null)
                    {
                        if (line1 == line2)
                        {
                            sameLines++;
                        }
                        else
                        {
                            diffLines++;
                        }

                        line1 = reader1.ReadLine();
                        line2 = reader2.ReadLine();
                    }
                }
            }

            Console.WriteLine("Еднакви редове - {0}, различни редове - {1}", sameLines, diffLines);
        }
    }
}
