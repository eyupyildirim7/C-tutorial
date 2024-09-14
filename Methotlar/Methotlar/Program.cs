using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //login_succes();
            int topla = toplama(25, 45);
            Console.WriteLine(topla);




            Console.ReadLine();

        }


        //    static void login_succes()
        //    { Console.WriteLine("Giris Basarili"); }
        //}

        static int toplama(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
          
        }
    }
}
