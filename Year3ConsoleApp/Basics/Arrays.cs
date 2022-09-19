using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Year3ConsoleApp.Basics
{
    public class Arrays
    {
        public static void ImplicitlyTypedArray()
        {
            //definition
            //those arrays in which the type of the array is deduced from the element specified in the array initializer

            //syntax
            //var iarray = new[] { 1, 2, 3 };

            //reference
            //https://www.geeksforgeeks.org/c-sharp-implicitly-typed-arrays/#:~:text=In%20C%23%2C%20the%20implicitly%20typed,var%20does%20not%20follow%20%5B%5D.

            //example
            // implicitly typed array
            var author_names = new[] {"Shilpa", "Soniya", "Shivi", "Ritika"};

            //assigning
            author_names[3] = "Ravan";

            Console.WriteLine($"List of Authors is: {author_names[3]}");
        }

        public static void JaggedArray()
        {
            //definition
            //are often called array of arrays

            //syntax
            //data_type[][] name_of_array = new data_type[rows][]

            //reference
            //https://www.programiz.com/csharp-programming/jagged-array

            //example
            int[][] jagged_arr = new int[][]
            {
                new int[] {1, 2, 3, 4},
                new int[] {11, 34, 67},
                new int[] {89, 23},
                new int[] {0, 45, 78, 53, 99}
            };

            //assiging 
            jagged_arr[1][2] = 99;

            //reading
            Console.WriteLine("jaggedArray[1][2]: " + jagged_arr[1][2]);
        }

        public static void MultiDimensionalArray()
        {
            //definition
            //data is stored in tabular form(row* column) which is also known as matrix

            //syntax
            //int[,] arr = new int[3, 3];//declaration of 2D array  
            //int[,,] arr = new int[3, 3, 3];//declaration of 3D array
            
            //reference
            //https://www.programiz.com/csharp-programming/multidimensional-arrays

            //example = declaration of 2D array  
            int[,] numbers = { { 2, 3 }, { 4, 5 } };

            // old element
            Console.WriteLine("Old element at index [0, 0] : " + numbers[0, 0]);

            // assigning new value
            numbers[0, 0] = 222;

            // new element
            Console.WriteLine("New element at index [0, 0] : " + numbers[0, 0]);
        }

        public static void SingleDimensionalArray()
        {
            //definition
            //simplest type of array that contains only one row for storing data

            //syntax
            //DataType[] VariableName = new DataType[Number];

            //reference
            //https://www.includehelp.com/dot-net/single-dimensional-arrays-in-c-sharp.aspx

            //example
            int[] array1 = { 1, 3, 5, 7, 9 };
            string[] weekDays2 = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

            //assigning
            array1[1] = 2;

            //reading
            Console.WriteLine(array1[1]);
            Console.WriteLine(weekDays2[3]);
        }
    }
}
