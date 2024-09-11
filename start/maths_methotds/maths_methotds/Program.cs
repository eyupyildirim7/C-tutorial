using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maths_methotds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Toplama islemleri//
            //int sayi1 = 15;
            //int sayi2 = 26;
            //int total = sayi1 + sayi2;

            //Console.WriteLine("Iki Sayinin Toplami:" + total);

            //int sayi3 = 15;
            //int sayi4 = 26;
            //int result = sayi1 - sayi2;

            //Console.WriteLine("Iki Sayinin Cikarilmasi:" + result);

            //int sayi1 = 8;
            //int sayi2 = 15;
            //int carpim = sayi1 * sayi2;
            //Console.WriteLine("Birinci sayi: "+sayi1 +"\nIkinci sayi:"+sayi2+"\niki sayinin carpimi:"+carpim);

            //int sayi1 =15;
            //int sayi2 =5;
            //int bolum = sayi1 / sayi2;
            //Console.WriteLine("Birinci sayi:{0}\nIkinci sayi:{1}\niki sayinin birbirine bolumu:{2}",sayi1,sayi2,bolum);

            //int sayi1 = 5;
            //int sayi2 = 2;
            //int kalan = sayi1 % sayi2;

            //Console.WriteLine(kalan);

            //double sayi1 = 5;
            //double sonuc = Math.Sqrt(sayi1);
            //Console.WriteLine("Girilen sayi:{0}\nGirilen sayinin karekoku:{1}",sayi1,sonuc);

            double sayi1 = 5;
            double sayi2 = 4;
            double result = Math.Pow(sayi1, sayi2);
            Console.WriteLine(result);


            Console.ReadLine();
        }
    }
}
