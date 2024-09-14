using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace default_values
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int write = age_calculate(1991);
            //Console.WriteLine(write);
            age_calculate(2000);
            Console.ReadLine(); 

        }
        static int age_calculate(int born_year,int year= 2023)
        {

            Console.WriteLine("Yasiniz: {0}",year-born_year);
            return year-born_year;
        }
    }
}
