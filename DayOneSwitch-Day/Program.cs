using System;
using System.Collections.Generic;
using System.Data;

namespace DayOneSwitch_Day
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            DateTime dt = DateTime.Now;
            switch (dt.DayOfWeek)
            {
                case DayOfWeek.Monday:
                case DayOfWeek.Thursday:
                case DayOfWeek.Wednesday:
                case DayOfWeek.Tuesday:
                case DayOfWeek.Friday:
                    Console.WriteLine("Today is A Weekday");
                    break;
                default:
                    Console.WriteLine("Todal is weekand day");
                    break;
            }
        }
    }
}