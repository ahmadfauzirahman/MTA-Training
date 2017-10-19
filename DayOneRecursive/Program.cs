using System;
using System.Collections.Generic;

namespace DayOneRecursive
{
    internal class Program
    {
       
        public static void Main(string[] args)
        {
            Console.WriteLine(Factorial(5));
        }
        
        private static int Factorial(int n)
        {
            if (n == 1) {
                return n=1;
            }else{
                return n * Factorial(n - 1);
            }
        }
    }
}