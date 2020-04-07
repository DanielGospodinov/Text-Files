using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("../../Conc1.txt");
            string text1 = reader.ReadToEnd();

            StreamReader reader2 = new StreamReader("../../Conc2.txt");
            string text2= reader2.ReadToEnd();

            string text3 = String.Concat(text1, text2);

            StreamWriter writer3 = new StreamWriter("../../Conc3.txt");

            using (writer3)
            {
                writer3.WriteLine(text3);
            }
        }
    }
}
