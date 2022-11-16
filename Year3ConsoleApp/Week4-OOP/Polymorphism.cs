using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Year3ConsoleApp.Week4_OOP
{
    //is the ability of objects of different types to provide a unique interface for different implementations of methods.It is usually used in the context of late binding,
    //where the behavior of an object to respond to a call to its method members is determined based on object type at run time.

    /*Compile time Polymorphism
     * Method Overloading => methods with same name, with different types and numbers of params
     * Operator Overloading => operators behaving differently with different operands (Like : +)
    */

    /*Runtime Polymorphism
     * Method Overridng => if the same method is present in both the superclass and the subclass. 
     *                  Then, the method in the subclass overrides the same method in the superclass.
     * 
     */

    public class Polymorphism
    {
        public void Hello() //Method overloading
        {
            Console.WriteLine("Hello");
        }

        public void Hello(string world = "Hello World") //method overloading
        {
            Console.WriteLine(world);
        }

        public void Hello(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public void Hello(string a, string b)
        {
            Console.WriteLine(a + b);
        }

        // Base Class
        public virtual void GetInfo() //method overriding
        {
            Console.WriteLine("This is base class.");
        }
    }

    // Derived Class
    public class PolyDerivedClass : Polymorphism
    {
        public override void GetInfo() //method overriding
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
            Polymorphism polymorphism = new Polymorphism();
            polymorphism.GetInfo(); 

            polymorphism.Hello();
            polymorphism.Hello("Multiple forms");
            polymorphism.Hello(1, 2);
            polymorphism.Hello(a, b);
        }
    }
}
