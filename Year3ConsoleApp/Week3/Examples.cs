using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Year3ConsoleApp.Week3
{
    public class Examples
    {
        public static void IsPrime(int num1)
        {
            bool flag = true;
            int num2, num3 = 0;

            //divide it by 2 and get remainder
            num3 = num1 / 2;

            //loop until the remainder is reach, check if it is divisble
            for (num2 = 2; num2 <= num3; num2++)
            {
                // if divisible by any number from 2 to m, then it is not prime
                if (num1 % num2 == 0)
                {
                    Console.WriteLine("Number is not Prime.");
                    flag = false;
                    break;
                }
            }
            // if flag = true, means,above code when flag = false is assigned is not executed and hence it is prime number
            if (flag == true)
            {
                Console.WriteLine("Number is Prime.");
            }
        }

        public static void OddEven(int num1)
        {
            if (num1 % 2 == 0)
            {
                Console.WriteLine($"Inserted number {num1} is an Even number.");
            }
            else
            {
                Console.WriteLine($"Inserted number {num1} is an Odd number.");

            }
        }

        public static void SwapNumbers(int num1, int num2)
        {
            int temp = 0;
            Console.WriteLine($"Orders of number before swap are {num1}, {num2}");

            temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine($"Orders of number after swapping are {num1}, {num2}");

        }

        public static void SimpleSearchInArrays()
        {
            var search = Console.ReadLine()?.ToLower();

            string[] dataArray = { "apple", "banana", "orange", "grape", "papaya" };

            foreach (var item in dataArray)
            {
                if (item == search)
                {
                    Console.WriteLine($"Item {search} is found.");
                    break;
                }
                else
                {
                    Console.WriteLine($"Item {search} is not found.");
                    break;
                }
            }

        }
    }
}
