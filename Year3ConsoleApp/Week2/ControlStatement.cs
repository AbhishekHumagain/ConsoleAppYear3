using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Year3ConsoleApp.Week2
{
    public class ControlStatement
    {
        public static void IfElse(int num1 , int num2)
        {
            if (num1 > num2)
            {
                Console.WriteLine($"{num1} is greater than  {num2}");
                goto Apple;
            }
            else if (num1 < num2)
            {
                Console.WriteLine($"{num1} is less than  {num2}");
            }
            else
            {
                Console.WriteLine($"{num1} equals to  {num2}");
            }

            Apple: Console.WriteLine("Apple Apple");
        }

        public static void SwitchCase()
        {
            Console.WriteLine("Press 1 for Apple");
            Console.WriteLine("Press 2 for Orange");

            var a = Console.ReadLine(); //get input from user

            switch (a)
            {
                case "1":
                    Console.WriteLine("Apple");
                break;
                    
                case "2":
                    Console.WriteLine("Orange");
                break;

                default:
                Console.WriteLine("Incorrect input");
                break;
            }
        }

        public static void WhileStatement(int num1)
        {
            while(num1 < 10)
            {
                Console.WriteLine(num1);
                    num1++;
            }
        }

        public static void DoWhileStatement(int num1)
        {
            do
            {
                Console.WriteLine(num1);
                num1++; //it will add 1 ☻in num1 value
            }
            while (num1 < 10);
        }

        public static void ForLoop(int num1)
        {
            for (int i = num1;  i < 5; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void ForEachLoop()
        {
            var fibNumbers = new List<int> { 0, 1, 1, 2, 3, 5, 8, 13 };
            foreach (int element in fibNumbers)
            {
                Console.Write($"{element} \n");
            }
        }

    }
}
