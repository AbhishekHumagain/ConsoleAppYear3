using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Year3ConsoleApp.Week4_OOP
{
    public class Encapsulation
    {
        // defined as the wrapping up of data under a single unit
        // encapsulation is a protective shield that prevents the data from being accessed by the code outside this shield
        //Data Hiding: The user will have no idea about the inner implementation of the class. It will not be visible to the user that how the class is stored values in the variables.

        private string? TeacherName;
        private int TeacherAge;

        public string Name //property
        {
            get { return TeacherName; }
            set { TeacherName = value; }
        }

        public int Age //property
        {
            get { return TeacherAge; }
            set { TeacherAge = value; }
        }
    }

    class DriverClass
    {
        public static void CallEncapsulation()
        {
            Encapsulation encapsulation = new Encapsulation();
            encapsulation.Name = "Abhishek";
            encapsulation.Age = 25;

            Console.WriteLine($"Name = {encapsulation.Name}");
            Console.WriteLine($"Age = {encapsulation.Age}");
        }
    }
}
