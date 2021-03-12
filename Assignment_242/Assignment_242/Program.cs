using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_242
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create String Array
            string[] names = new string[] { "John", "Mary", "Mable", "Tom", "Jose" };
            //Request user input
            Console.WriteLine("Enter a number 0 thru 4 to display a name:");
            //Save user input
            int number = Convert.ToInt32(Console.ReadLine());
            //Write name
            Console.WriteLine(names[number]);

            //Create Interger Array
            int[] numArray = { 1, 4, 12, 33, 102, 43 };

            //Request user input
            Console.WriteLine("Enter a number 0 thru 5 to display a number: ");
            //Save user input
            int number1 = Convert.ToInt32(Console.ReadLine());
            // Check array length and save
            int listLength = (numArray.Length) - 1;

            //Check to see if User input is within array size
            if (listLength >= number1)
            {
                //Write number
                Console.WriteLine(numArray[number1]);
            }

            //If User input is greater than array
            if (listLength < number1)
            {
                // Try again
                Console.WriteLine("Number entered was greater than :" + listLength);
            }


            //try
            //{
            //    //Request user input
            //    Console.WriteLine("Enter a number 0 thru 5 to display a number: ");
            //    //Save user input
            //    int number2 = Convert.ToInt32(Console.ReadLine());
            //    //Write number
            //    Console.WriteLine(numArray[number2]);
            //}
            //catch
            //{
            //    Console.WriteLine("Error occured");
            //}
            //finally
            //{
            //    Console.WriteLine("Re-try with a different numer.");
            //}

            // Create String List
            var namesCities = new List<string>()
            { "South Bend", "Chicago", "Detriot", "Cleveland"};

            // Print out each name in list
            foreach(var name in namesCities) 
            {
                Console.WriteLine(name);
            }

            //request user input
                Console.WriteLine("enter a number 0 thru 3 to display a Name: ");

            //save user input
            int number3 = Convert.ToInt32(Console.ReadLine());

            // Check array length and save
            int listLength2 = (namesCities.Count)-1;
 
            //Check to see if User input is within list size
            if (listLength2 >= number3)
            {
                //Write number
                Console.WriteLine(namesCities[number3]);
            }

            //If User input is greater than array
            if (listLength2 < number3)
            {
                // Try again
                Console.WriteLine("Number entered was greater than :" + listLength2);
            }





            Console.ReadLine();
            
        }
    }
}
