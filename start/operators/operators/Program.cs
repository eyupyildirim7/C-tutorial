using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
             //== esit midir ?//
            int yas = 21;
            int kural = 21;
            var result = yas == kural;
            //Console.WriteLine(result);

            // != esit degil midir ?//
            int yas1 = 21;
            int kural1 = 21;
            var result1 = yas1 != kural1;
            //Console.WriteLine(result1);

            // > || >= buyuktur yada buyuk esittir //
            // < || <= kucuktur  yada kucuk esittir //
            int kural0 = 25;
            int kural11 = 25;
            var resul01 = kural0 > kural11;
            var resul02 = kural0 >= kural11;

            Console.WriteLine(resul01);
            Console.WriteLine(resul02);


            //Ve &&
            //Veya  ||








            Console.ReadLine();
        }
    }
}
