using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wala_lang_ulet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] bCard = new int[5, 5];
            List<int> listNum = new List<int>();
            Random rnd = new Random();
            int num = 0;

            for (int x = 0; x < bCard.GetLength(0); x++) //card row
            {
                listNum.Clear();
                for (int c = 1; c < 16; c++) //for generating possible numbers from 1-15
                {
                    listNum.Add(c);
                }

                for (int y = 0; y < bCard.GetLength(1); y++) //card col
                {
                    //generate numbers
                    num = rnd.Next(0, listNum.Count);
                    bCard[y, x] = listNum[num];
                    listNum.RemoveAt(num);
                }
            }

            Console.WriteLine("B\tI\tN\tG\tO");
            for (int x = 0; x < bCard.GetLength(0); x++)
            {
                for (int y = 0; y < bCard.GetLength(1); y++)
                {
                    bCard[x, y] += (15 * y);
                    Console.Write(bCard[x, y] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
