using System;
using System.Collections.Generic;
using System.IO;

namespace DayOneExceptionHandling
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ExceptionTest();
            
        }

        private static void ExceptionTest()
        {
            StreamReader sr = null;
            try
            {
                sr = File.OpenText(@"/media/ojikdev/Kuliah/text.txt");
                Console.WriteLine(sr.ReadToEnd());
            }
            catch (FileNotFoundException fnfe)
            {
                Console.WriteLine(fnfe.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}