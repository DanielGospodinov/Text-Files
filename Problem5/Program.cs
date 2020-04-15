using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Problem5
{
    class Program
    {
        static int[,] InitMatrix()
        {
            StreamReader reader = new StreamReader("../../text1.txt");
            int size = 0;
            int[,] arr;

            using (reader)
            {
                size = int.Parse(reader.ReadLine());
                arr = new int[size,size];

                for(int x = 1; x<=4;x++)
                {
                    string[] numbersInFile = reader.ReadLine().Split(' ');

                    for(int y = 0; y<numbersInFile.Length;y++)
                    {
                        arr[x-1,y] = int.Parse(numbersInFile[y]);
                    }
                }
                
            }

            return arr;
        }

        static int ReturnMax(int[,] arr)
        {
            int max = 0,current = 0;

            for (int i = 0; i < arr.GetLength(0)-1; i++)
            {
                for (int y = 0; y < arr.GetLength(1)-1; y++)
                {
                    current = arr[i, y] + arr[i, y + 1] + arr[i + 1, y] + arr[i + 1, y + 1];

                    if (current > max) max = current;

                }
            }
            return max;
        }

        static void CreateTextResult(int result)
        {
            StreamWriter writer = new StreamWriter("../../text2.txt");

            using (writer)
            {
                writer.WriteLine(result.ToString());
            }
        }
        static void Main(string[] args)
        {
            int[,] matrix = InitMatrix();

            int maxResult = ReturnMax(matrix);

            CreateTextResult(maxResult);

        }
    }
}
