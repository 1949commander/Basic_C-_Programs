using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_Catch_Assignment_Step_388
{
    class Program
    {
        static void Main(string[] args)
        {
            // GET CURRENT DATE TIME
            DateTime nowYear = DateTime.Now;
            // Assign an Int Variable
            int age = 0;
            // Try Catch for Exceptions
            try
            {
                // USER INPUT REQUEST
                Console.WriteLine("Please enter your age: ");
                // ERROR CHECK FOR PROPER VALUE
                while (!int.TryParse(Console.ReadLine(), out age) || age <=0)
                {
                    Console.WriteLine("Please enter non-negative whole values only!");
                }
                // Calculate Year Born        
                int yearBorn = nowYear.Year - age;
                // Print results
                Console.WriteLine("The current year is: {0} your age is: {1} You were born in this year: {2}", nowYear.Year, age, yearBorn);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
           

            Console.ReadLine();

        }
    }
}
