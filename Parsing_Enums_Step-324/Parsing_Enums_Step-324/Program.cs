using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parsing_Enums_Step_324
{
    class Program
    {
        //Create ENUM 
        enum DayOfWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {
            //Ask user to enter day of week
            Console.WriteLine("Enter the current day of the week: ");
            string dayOfWeek = Console.ReadLine();

            //Try to see if user value matches ENUM Values
            try
            {
                DayOfWeek dayValue = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), dayOfWeek, true);
                
                if (Enum.IsDefined(typeof(DayOfWeek), dayValue) | dayOfWeek.ToString().Contains(","))
                    Console.WriteLine("Value Entered: '{0}' Today is: {1}.", dayOfWeek, dayValue.ToString());
                else
                    Console.WriteLine("{0} is not an underlying value of the Day of Week enumeration.", dayOfWeek);
            }

            //Tell user to enter a valid day of the week
            catch (ArgumentException)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            Console.ReadLine();
        }
    }
}
