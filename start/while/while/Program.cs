using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int i =  1;

            //while (i <= 10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //int num ,sum = 0;
            //Console.Write("Lutfen bir sayi giriniz:");
            //num =int.Parse(Console.ReadLine());
            //int i = 1;
            //while( i<= num)
            //{
            //   if (i%2 != 0)
            //    {
            //        sum += 1;

            //    }
            //   i++;
            //}
            //Console.WriteLine("Secilen sayi; " + num + "Tek sayilarin toplami: " + sum);

            //int num, fact = 1;
            //Console.Write("Lutfen bir sayi giriniz:");
            //num =int.Parse(Console.ReadLine());
            //int i = 1;
            //while (i <= num) {
            //    fact *= i;
            //    i++;    
            //}
            //Console.WriteLine("Girilen sayi{0}:,Faktoryeli ise {1}", num, fact);



            int num, total = 0;
            Console.Write("Lutfen bir sayi giriniz:");
            num =int.Parse(Console.ReadLine());
            int i = 0;
            while (i <= num) {
                total += i;
                i++;
            }
            Console.WriteLine("Girilen sayi {0},Girilen sayiya kadar olan sayilarin toplami:{1}",num,total);










            Console.ReadLine();
        }
    }
}
