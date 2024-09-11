using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forexamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i < 8; i++)
            //{
            //    for (int j = 0; j < 8; j++)
            //    {
            //        if ((i + j) % 2 == 0)
            //        {
            //            Console.WriteLine("X");
            //        }
            //        else
            //        {
            //            Console.Write("0");
            //        }
            //    }

            //}
            //Console.WriteLine();

            for (int i = 1; i <= 10; i++)
            {

                for (int j = 1; j <= 10; j++)
                {
                    {
                        Console.WriteLine(i * j + "\t");
                    }
                    Console.WriteLine();



                }
            }

            Console.ReadLine();
        }
    }
}
