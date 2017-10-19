using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace Mutli_Choice
{
    internal class Program
    {
        public static void Main(string[] args)
        {
//            SoapLanguage 1
            Console.WriteLine("Soal 1");
            int n = 20;
            int d = n++ + 5;
            Console.Write(d);
            
//            SoapLanguage 2
            Console.WriteLine("Soal 1");
            int i = 1;
            while (i < 5)
            {
                Console.WriteLine("THe value of i {0} ",i);
                i++;
            }
            Console.WriteLine("Soal 1");
            int number1 = 10;
            int number2 = 20;
            if(number2 > number1)
                Console.WriteLine("number1");
                Console.WriteLine("number2");

        }
    }
}