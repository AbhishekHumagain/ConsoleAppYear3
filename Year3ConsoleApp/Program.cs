// See https://aka.ms/new-console-template for more information

using Year3ConsoleApp.Basics;
using Year3ConsoleApp.Testing;


//getting input from users
// Declare variables and then initialize to zero.
int num1 = 0; int num2 = 0;

// Display title as the C# console calculator app.
Console.WriteLine("Console Calculator in C#\r");
Console.WriteLine("------------------------\n");

// Ask the user to type the first number.
Console.WriteLine("Type a number, and then press Enter");
num1 = Convert.ToInt32(Console.ReadLine());

// Ask the user to type the second number.
Console.WriteLine("Type another number, and then press Enter");
num2 = Convert.ToInt32(Console.ReadLine());

// Ask the user to choose an option.
Console.WriteLine("Choose an option from the following list:");
Console.WriteLine("Press 1 for Addition");
Console.WriteLine("Press 2 for Subtraction");
Console.WriteLine("Press 3 for Multiplication");
Console.WriteLine("Press 4 for Division");
Console.WriteLine("Press 5 for Jagged Arrays");
Console.WriteLine("Press 6 for SingleDimensional Arrays");
Console.WriteLine("Press 7 for ImplicitlyTyped Arrays");
Console.WriteLine("Press 8 for MultiDimensional Arrays");
Console.Write("Your option? ");


// Use a switch statement to do the math.
switch (Console.ReadLine())
{
    case "1":
        Calculator.Additions(num1, num2);
        break;
    case "2":
        Calculator.Subtraction(num1, num2);
        break;
    case "3":
        Calculator.Multiplication(num1, num2);
        break;
    case "4":
        Calculator.Division(num1, num2);
        break;
    case "5":
        Arrays.JaggedArray();
        break;
    case "6":
        Arrays.SingleDimensionalArray();
        break;
    case "7":
        Arrays.ImplicitlyTypedArray();
        break;
    case "8":
        Arrays.MultiDimensionalArray();
        break;
    default:
        Interpolation.StringInterpolation();
        break;
}

// Wait for the user to respond before closing.
Console.Write("Press any key to close the Calculator console app...");
Console.ReadKey();
