using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Year3ConsoleApp.Week5
{
    public class Types
    {
        //guid (Globally Uinque Identifier)
        public static Guid ReturnGuid()
        {
            //Guid is globally unique identifier (GUID), there is very low probability of being duplicated across all DB and computer.

            Guid id = Guid.NewGuid();
            return id;
        }

        public DateTime DateTimeExample()
        {
            //The DateTime represents a combined date and time value for a fixed point in time and allows you to get the current time.

            //reference for datetime formats 
            //https://www.c-sharpcorner.com/blogs/date-and-time-format-in-c-sharp-programming1

            // Creating DateTime value
            DateTime newYearEve = new(year: 2022, month: 12, day: 31);
            DateTime newYearEve2 = new(year: 2022, month: 12, day: 31, hour: 23, minute: 59, second: 59);
            DateTime newYearEve3 = DateTime.Parse("12/31/2022 23:59:59");


            // Current DateTime value
            DateTime nowLocal = DateTime.Now.AddMonths(5); // As determined by this computer
            DateTime nowUtc = DateTime.UtcNow; // UTC = GMT = Z Time or Zulu Time
            DateTime today = DateTime.Today; // Same as DateTime.Now but time is 00:00:00
            DateTime tomorrow = today.AddDays(1);


            if (today.Month == 4 && today.Day == 1)
                Console.WriteLine("April Fools!");


            int result = DateTime.Compare(nowUtc, nowLocal); // -1
            return newYearEve;
        }

        public TimeSpan TimeSpanExample() 
        {
            //The TimeSpan represents a length of time.

            TimeSpan timeSpan1 = new TimeSpan(1, 30, 0); // 1 hour, 30 minutes, 0 seconds.
            TimeSpan timeSpan2 = new TimeSpan(2, 12, 0, 0); // 2 days, 12 hours.
            TimeSpan timeSpan3 = new TimeSpan(0, 0, 0, 0, 500); // 500 milliseconds.
            TimeSpan timeSpan4 = new TimeSpan(10); // 10 "ticks" == 1 microsecond or 1000 nanoseconds


            TimeSpan aLittleWhile = TimeSpan.FromSeconds(5);
            TimeSpan quiteAWhile = TimeSpan.FromHours(1.5);
            // The whole collection includes FromTicks, FromMilliseconds, FromSeconds, FromHours, and FromDays.


            TimeSpan timeLeft = new TimeSpan(1, 30, 0);
            Console.WriteLine($"{timeLeft.Days}d {timeLeft.Hours}h {timeLeft.Minutes}m {timeLeft.Seconds}s"); // 0d 1h 30m 0s
            Console.WriteLine(timeLeft.TotalHours); // 1.5
            Console.WriteLine(timeLeft.TotalMinutes); // 90


            DateTime nextNewYear = new(2023, 1, 1);
            TimeSpan newYearTimeLeft = nextNewYear - DateTime.Now; // 42.12:06:27.7876334
            return newYearTimeLeft;
        }

        public static void StringBuilderExample()
        {
            //The StringBuilder doesn't create a new object in the memory but dynamically expands memory to accommodate the modified string.
            //reference for string buiilder
            //https://www.tutorialsteacher.com/csharp/csharp-stringbuilder

            string[] todoList = { "Walk the dog.", "Buy some fruits.", "Pay the water bill." };
            string today = DateTime.Today.ToShortDateString();
            StringBuilder pritableTodo = new($"Todo - {today}\n");
            pritableTodo.AppendLine("=================");
            foreach (var todo in todoList)
            {
                pritableTodo.AppendLine($"[ ] {todo}");
            }


            // Use ToString method to get the string
            Console.WriteLine(pritableTodo.ToString());
        }


        public List<string> ListExample()
        {
            //List<T> is a popular and versatile generic collection. It provides methods to search, sort, and manipulate lists.

            //reference for list and dictionary
            //https://www.softwaretestinghelp.com/c-sharp/csharp-list-and-dictionary/

            List<string> fruits = new() { "apple", "banana", "pineapple", "durian" };
            Console.WriteLine(fruits.Count); // 4
            Console.WriteLine(fruits[2]); // pineapple
            fruits[1] = "avocado"; // => replace an item in a list
            fruits.Add("kiwi");
            fruits.Insert(2, "orange");

            return fruits;
        }

        public Dictionary<string, int> DictionaryExample()
        {
            //Dictionary<TKey, TValue> allows us to store a set of keys and values. The key must be unique.

            Dictionary<string, int> dict = new Dictionary<string, int>();

            dict.Add("squash", 1);
            dict.Add("football", 2);
            dict.Add("rugby", 3);

            return dict;
        }
    }
}
