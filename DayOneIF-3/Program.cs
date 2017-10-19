using System;
using System.Collections.Generic;

namespace DayOneIF_3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Masukan Huruf Angka");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n < 10)
            {
                Console.WriteLine("N Lebih Kecil Dari  10");
            }
            else if (n < 20)
            {
                Console.WriteLine("N Lebih Kecil Dari  20");
            } else if (n < 30)
            {
                Console.WriteLine("N Lebih Kecil Dari  30");
            }
            else
            {
                Console.WriteLine("Unknow Number");
            }
        }
    }
}