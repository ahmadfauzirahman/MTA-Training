using System;
using System.Collections.Generic;

namespace DayTwo_Oop
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int x = 9;
            int y = 4;
            int z = x++ - y-- + (x + y);
            Console.Write(--z % 2);
            
            Console.WriteLine("======================");
            Console.WriteLine("======================");
        
            int[] a = new int[1];
            a[0] = 3;
            int b = 4;
            Squere(ref b);
            Console.WriteLine(a[0] +b);
            Console.WriteLine("======================");
        }
        static int Squere(ref int x)
        {
            x *=x;
            return x;
        }
    }
}