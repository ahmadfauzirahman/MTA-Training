using System;
using System.Collections.Generic;

namespace OneDayForTest
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Masukan X");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();
            
            Console.WriteLine("Masukan Y");
            int y = Convert.ToInt32(Console.ReadLine());
            
            ForTest(i,y);
        }

        private static void ForTest(int i , int y)
        {
            for (i = 0; i <= y; i++)
            {
               Console.WriteLine("The value of i = {0}",i);
            }
        }
    }
}