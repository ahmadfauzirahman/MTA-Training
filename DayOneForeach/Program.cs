using System;
using System.Collections.Generic;

namespace DayOneForeach
{
    internal class Program
    {
        private static void Foreach()
        {
            int[] numbers = {1, 2, 3, 4, 5};
            foreach (int i in numbers)
            {
                Console.WriteLine("THE VALUE OF I = {0}",i);
            }
        }
        
        public static void Main(string[] args)
        {
         Foreach();
        }
    }
}