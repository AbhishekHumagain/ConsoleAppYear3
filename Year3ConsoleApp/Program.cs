// See https://aka.ms/new-console-template for more information

using Year3ConsoleApp.Basics;
using Year3ConsoleApp.Testing;
using Year3ConsoleApp.Week2;
using Year3ConsoleApp.Week3;
using Year3ConsoleApp.Week4_OOP;
using Year3ConsoleApp.Week5;


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
Console.WriteLine("Press 9 for If-Else Statement Example");
Console.WriteLine("Press 10 for Switch-Case Statement Example");
Console.WriteLine("Press 11 for While Statement Example");
Console.WriteLine("Press 12 for Do-While Statement Example");
Console.WriteLine("Press 13 for For Statement Example");
Console.WriteLine("Press 14 for For-Each Statement Example");
Console.WriteLine("Press 15 for Prime number check Example");
Console.WriteLine("Press 16 for OddEven number check Example");
Console.WriteLine("Press 17 for swap two numbers check Example");
Console.WriteLine("Press 18 for search in arrays Example");
Console.WriteLine("Press 19 for Encapsulation Example");
Console.WriteLine("Press 20 for Inheritance Example");
Console.WriteLine("Press 21 for Abstraction Example");
Console.WriteLine("Press 22 for Polymorphism Example");
Console.WriteLine("Press 23 for JsonSerialize Example");
Console.WriteLine("Press 24 for JsonDeserialize Example");
Console.WriteLine("Press 25 for List Example");
Console.Write("Your option? ");

var a = Console.ReadLine();
// Use a switch statement to do the math.
switch (a)
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
    case "9":
        ControlStatement.IfElse(num1, num2);
        break;
    case "10":
        ControlStatement.SwitchCase();
        break;
    case "11":
        ControlStatement.WhileStatement(num1);
        break;
    case "12":
        ControlStatement.DoWhileStatement(num1);
        break;
    case "13":
        ControlStatement.ForLoop(num1);
        break;
    case "14":
        ControlStatement.ForEachLoop();
        break;
    case "15":
        Examples.IsPrime(num1);
        break;
    case "16":
        Examples.OddEven(num1);
        break;
    case "17":
        Examples.SwapNumbers(num1, num2);
        break;
    case "18":
        Examples.SimpleSearchInArrays();
        break;
    case "19":
        DriverClass.CallEncapsulation();
        break;
    case "20":
        MainClass.AssignValue();
        break;
    case "21":
        CallingClass.AbstractionCall();
        break;
    case "22":
        PolyMainClass.PolyMainMethod();
        break;
    case "23":
        Json.SerializeExample();
        break;
    case "24":
        Json.DeserializeExample();
        break;
    case "25":
        ListData.Newlist();
        break;
    default:
        Interpolation.StringInterpolation();
        break;
}

// Wait for the user to respond before closing.
Console.Write("Press any key to close the Calculator console app...");
Console.ReadKey();


//Reference
//https://www.programiz.com/csharp-programming/access-modifiers
//https://www.geeksforgeeks.org/access-modifiers-in-c-sharp/
//https://www.programiz.com/csharp-programming/abstract-class

/*
git*/
//https://education.github.com/git-cheat-sheet-education.pdf
//https://www.simplilearn.com/tutorials/git-tutorial/git-tutorial-for-beginner
//https://www.javatpoint.com/git
//https://www.freecodecamp.org/news/learn-the-basics-of-git-in-under-10-minutes-da548267cc91/