using System;
using System.Collections.Generic;

namespace DayOne_For
{
    internal class Program
    {
            
        public static void Main(string[] args)
        {
         
            Console.WriteLine("Masukan Angka");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();
            
            Console.WriteLine("Masukan Jumalah Perulangan = ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();

            for (i = 0; i < n; i++)
            {
                Console.WriteLine("The Value Of i = {0}",i);
            }

        }
    }
}