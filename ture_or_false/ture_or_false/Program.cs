using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ture_or_false
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lutfen bir sayi giriniz:");
            int sayi = int.Parse(Console.ReadLine());

            if (sayi > 0)
            {
                Console.WriteLine("Sayi pozitif:{0}", sayi);

            }
            else if (sayi < 0) {
                Console.WriteLine("Sayi Negatiftir:{0}", sayi);
                    }
            else
            {
                Console.WriteLine("Sayi 0`dir {0}",sayi);
            }
            



            Console.ReadLine();
        }
    }
}
