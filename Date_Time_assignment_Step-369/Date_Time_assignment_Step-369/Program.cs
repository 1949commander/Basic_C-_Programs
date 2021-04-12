using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_Time_assignment_Step_369
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get Current Date and Time
            DateTime dateTime = DateTime.Now;
            Console.WriteLine(dateTime);
            // Request hours offset
            Console.WriteLine("Please enter a whole number: ");
            int hours = Convert.ToInt32(Console.ReadLine());
            //Add hours offset to date time
            DateTime dateTime1 = dateTime.AddHours(hours);
            //Display new date time with offset
            Console.WriteLine(dateTime1);
         
            Console.ReadLine();

        }
    }
}
