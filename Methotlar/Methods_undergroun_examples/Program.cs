using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_undergroun_examples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kare hesaplama 
            //Console.WriteLine(karehesapla(5));

            //dizi hesaplama
            //string[] isimler = { "Eyup", "Mustafa ", "Yildirim", "Seyda", "Armagan" };
            //string[] isimler1 = { "hakki", "selami ", "Yildirim", "niyazi", "cemil" };

            //ArrayYazdir(isimler);
            //Console.WriteLine("----------------------");
            //ArrayYazdir(isimler1);


            int[] numbers = { 10, 20, 30, 40, 50, 60, 70, 80, 90 };
            ArrayYazdirInt(numbers);


            Console.ReadLine();


        }

        //Kare alma fonksiyonu //
        static int karehesapla(int num)
        {
            return num * num;
        }
        //array listesini yazdir//

        static void ArrayYazdir(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        //Array listesini yazdir tam sayilar ile //
        static void ArrayYazdirInt(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
