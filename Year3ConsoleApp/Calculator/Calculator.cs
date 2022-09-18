using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Year3ConsoleApp.Testing
{
    public class Calculator
    {
        public static void Additions(int num1, int num2)
        {
            Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
        }

        public static void Subtraction(int num1, int num2)
        {
            Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
        }

        public static void Multiplication(int num1, int num2)
        {
            Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
        }

        public static void Division(int num1, int num2)
        {
            Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
        }
    }
}
