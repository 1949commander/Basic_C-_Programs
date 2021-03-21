using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment_251
{
    class Program
    {
        static void Main(string[] args)
        {
            //// PART ONE
            //// Loop and append

            //string[] citiesArray = { "Boston", "New York", "Atlanta", "Dallas", "Omaha", "Seattle", "San Francisco", "Bosie" };

            //Console.WriteLine("Please enter a name: ");
            //string nameAdd = Console.ReadLine();
            //for (int i = 0; i < citiesArray.Length; i++)
            //{
            //    citiesArray[i] = citiesArray[i] + " " + nameAdd;
            //}
            //foreach (string i in citiesArray)
            //{
            //    Console.WriteLine(i);
            //}

            //// PART TWO
            //// Creating infinite loop 
            //// using while loop 

            //int count = 0;
            //while (true)
            //{
            //    // This statement will be printed  
            //    // infinite times  
            //    Console.WriteLine("I am stuck in a rut!!! but only this many times = {0}. ", count);
            //    // Added Count
            //    count++;

            //    if (count > 10)
            //    {
            //        break;
            //    }
            //}

            //// PART THREE
            //// Loop and Compare

            //// Step one
            //int j = 0;

            //do
            //{
            //    Console.WriteLine("j = {0}", j);
            //    j++;

            //    if (j > 5)
            //        break;
            //}

            //while (j < 10);

            //// Step two
            //for (int k = 0; k <= 12; k++)
            //    Console.WriteLine("Value of k: {0}", k);

            // PART FOUR
            // STRING LOOP
            // Create List of Strings
            List<string> namesList = new List<string>() { "John", "Billy", "James", "Susan", "Mary", "Kathy", "Nitu" };

            // Ask for user input
            Console.WriteLine("Please enter a name to search for: ");

            //Save User input into a variable
            string searchName = Console.ReadLine();

            //Loop search
            for (int m = 0; m < namesList.Count; m++)
            {
                if (namesList[m].ToLower() == searchName.ToLower())
                {
                    int idx = namesList.IndexOf(searchName);
                    Console.WriteLine(idx);
                    break;
                }

                else
                {
                    Console.WriteLine("Name you entered is not in the list");
                }
                Console.WriteLine(m);
            }




            //if (m.ToLower() == searchName.ToLower())
            //{
            //    int idx = namesList.IndexOf(nameof);
            //    Console.WriteLine(idx);
            //}



            //for (int m = 0; m < namesList.Count; m++)
            // foreach ( var name in namesList)
            //    if (searchName = m
            //    { }

            Console.ReadLine();
        }
    }
}