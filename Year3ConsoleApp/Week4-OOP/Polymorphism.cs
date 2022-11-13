using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Year3ConsoleApp.Week4_OOP
{
    public class Polymorphism
    {
        //In abstract class, we use abstract keyword to method but in polymorphism uses virtual keyword to base class method.
        //We are overriding the base class method GetInfo in the derived class by creating the same function to achieve method overriding.
        //We defined a GetInfo method with a virtual keyword in the base class to allow the derived class to override that method using the override keyword.
        //Only the methods with a virtual keyword in the base class are allowed to override in derived class using override keyword.

        // Base Class
        public virtual void GetInfo()
        {
            Console.WriteLine("This is base class.");
        }
    }

    // Derived Class
    public class PolyDerivedClass : Polymorphism
    {
        public override void GetInfo()
        {
            Console.WriteLine("This is derived class.");
        }
    }

    public class PolyMainClass
    {
        public static void PolyMainMethod()
        {
            PolyDerivedClass d = new PolyDerivedClass();
            d.GetInfo();
            Polymorphism b = new Polymorphism();
            b.GetInfo();
        }
    }
}
