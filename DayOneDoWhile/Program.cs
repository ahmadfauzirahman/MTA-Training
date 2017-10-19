using System;
using System.Collections.Generic;

namespace DayOneDoWhile
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Do While Statments");
            DoWhileTest();
        }

        private static void DoWhileTest()
        {
            int i = 1;
            do
            {
               Console.WriteLine("The Value of i = {0}",i);
                i++;
            } while (i > 5);
        }
    }
}