using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_for_each
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] names = { "Eyup", "Mustafa", "Salih", "Esila" ,"Gunes"};

            //for (int i = 0; i < names.Length; i++) { 
            //    Console.WriteLine(names[i]);
            //}

            //for (int i = 0; i < 101; i++)
            //{
            //    Console.WriteLine(i);
            //}

            string[] names = { "Eyup", "Mustafa", "Salih", "Esila", "Gunes" };

            foreach (var name in names) { 
            Console.WriteLine(name);
            }




            Console.ReadLine(); 
        }
    }
}
