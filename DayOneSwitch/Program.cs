using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DayOneSwitch
{
    internal class Program
    {
        public static void TestSwitch(int op1, int op2, char opr)
        {
            int result;
            switch (opr)
            {
                case '+':
                    result = op1 + op2;
                    break;
                case '-':
                    result = op1 - op2;
                    break;
                case '*':
                    result = op1 * op2;
                    break;
                case '/':
                    result = op1 / op2;
                    break;
                default:
                    Console.WriteLine("Unknow operator");
                    return;
                   break;
            }
            Console.WriteLine("Result : {0}",result);
            return;
        }

        public static void Main(string[] args)
        {
            TestSwitch(2,3,'-');
        }
    }
}