using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            numbers[0] = 1991;
            numbers[1] = 16;
            numbers[2] = 07;
            numbers[3] = 32;
            numbers[4] = 68;

            Array.Resize(ref numbers,6);
            numbers[5] = 798;

            string[] names =new string[6];
            names[0] = "Eyup";
            names[1] = "Yildirim";
            names[2] = "Eyup Mustafa Yildirim";
            names[3] = "Eyup YILDIRIM";
            names[4] = "Software";
            names[5] = "Developer";

            Array.Resize(ref names,7);
            names[6] = "c# Kursu";

            //Basit Yontem
            int[] school_no = { 25, 36, 85, 96, 36, 28, 99, 112 };
            string[] student_name = { "Eyup", "YILDIRIM", "MEHMET", "HAKKI", "SUKRU" };
            int index =Array.IndexOf(student_name, "Eyup");
            //Console.WriteLine(index);


            Console.WriteLine("Okul Numaralarinda Toplam: {0},Ogrenci vardir", school_no.Length);
            //Console.WriteLine(school_no[6]);



            Console.ReadLine();
        }
    }
}
