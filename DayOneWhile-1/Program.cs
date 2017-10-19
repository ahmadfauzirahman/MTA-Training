using System;
using System.Collections.Generic;

namespace DayOneWhile_1
{
    internal class Program
    {
        
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Masukan Nilai ");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();
            Console.WriteLine("Masukan Nilai Perulangan");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();
            
            while (i <= n)
            {
                Console.WriteLine("The Value of i = {0}" ,i);
                i++;
            }
        }
    }
}