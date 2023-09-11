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
            string disp = "";
            int dispCount = 0;
            string answer = "";
           
            while(true)
            {
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

                Console.WriteLine(" B\t I\t N\t G\t O");
                for (int x = 0; x < bCard.GetLength(0); x++)
                {
                    for (int y = 0; y < bCard.GetLength(1); y++)
                    {
                        bCard[x, y] += (15 * y);
                        disp = bCard[x, y].ToString();
                        dispCount = disp.Length;
                        while (dispCount != 3)
                        {
                            Console.Write("0");
                            dispCount++;
                        }
                        Console.Write(bCard[x, y] + "\t");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("Would you like to regenerate the card? [Y/N]");
                answer = Console.ReadLine().ToUpper();
                if (answer == "Y")
                {
                    for (int x = 0; x < bCard.GetLength(0); x++)
                    {
                        for (int y = 0; y < bCard.GetLength(1); y++)
                        {
                            bCard[x, y] = 0;
                        }
                    }
                }
                else
                    break;

            }
            
            Console.ReadKey();
        }
    }
}
