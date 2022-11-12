using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Year3ConsoleApp.Week4_OOP
{
    public class Inheritance //base class
    {
        //the mechanism in C# by which one class is allowed to inherit the features(fields and methods) of another class.

        public string? TeacherName;
        public string? Subject;

        // public method of base class 
        public void DisplayValue(string name, string subject)
        {
            this.TeacherName = name; // this == refers to the current instance of the class 
            this.Subject = subject;
            Console.WriteLine($"Teacher Name: {TeacherName}");
            Console.WriteLine($"My Favorite Subject is: {Subject}");
        }
    }

    class InheritingClass : Inheritance //Inherit base class
    {
        public InheritingClass()
        {
            Console.WriteLine("Inheriting Class");
        }
    }


    class MainClass
    {
        public static void AssignValue()
        {
            InheritingClass inheritingClass = new InheritingClass();
            inheritingClass.DisplayValue("Abhishek", "Application Development");
        }
    }


}
