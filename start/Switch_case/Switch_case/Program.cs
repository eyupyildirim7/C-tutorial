using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("lutfen bir harf giriniz:");
            char harf = char.Parse(Console.ReadLine());

            switch (harf)
            {
                case 'a':
                case 'e':
                case 'ı':
                case 'i':
                case 'o':
                case 'ö':
                case 'u':
                case 'ü':
                    Console.WriteLine("Girdiginiz harf Unludur:{0}", harf);
                    break;
                default:
                    Console.WriteLine("Girdiginiz harf Unsuzdur{0}",harf);
                    break;

            }



            Console.ReadLine(); 
        }
    }
}
