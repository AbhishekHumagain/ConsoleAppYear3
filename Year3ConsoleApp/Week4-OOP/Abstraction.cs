using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Year3ConsoleApp.Week4_OOP
{
    abstract class Abstraction
    {
        //C# abstraction is achieved with the help of Abstract classes and Access modifiers
        //you are not allowed to create objects of the abstract class
        //You are not allowed to declare the abstract methods outside the abstract class

        public abstract string TeacherName();
    }

    class AgeData : Abstraction //inheriting abstraction class
    {
        private int Age;

        public AgeData(int x = 0)
        {
            Age = x;
        }

        public override string TeacherName() //overriding of the abstract
        {
            Console.WriteLine("Teacher Age is");
            return ($"{Age}");
        }
    }

    class CallingClass
    {
        public static void AbstractionCall()
        {
            AgeData abstraction = new AgeData(25); //creating reference of Age data class which refers to abstraction class instance

            string result = abstraction.TeacherName();
            Console.WriteLine(result);

        }
    }
}
