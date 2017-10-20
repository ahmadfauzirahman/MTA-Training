using System;
using System.Collections.Generic;

namespace DayTwo_ClassObjecMethod
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Rectangle a = new Rectangle(20,5);
            Console.WriteLine("Area of rectangle : {0}",a.GetArea());
            
        }
    }
}