using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment_251
{
    class Program
    {
        static void Main(string[] args)
        {
            // PART ONE
            // Loop and append

            string[] citiesArray = { "Boston", "New York", "Atlanta", "Dallas", "Omaha", "Seattle", "San Francisco", "Bosie" };

            Console.WriteLine("Please enter a name: ");
            string nameAdd = Console.ReadLine();
            for (int i = 0; i < citiesArray.Length; i++)
            {
                citiesArray[i] = citiesArray[i] + " " + nameAdd;
            }
            foreach (string i in citiesArray)
            {
                Console.WriteLine(i);
            }

            // PART TWO
            // Creating infinite loop 
            // using while loop 

            int count = 0;
            while (true)
            {
                // This statement will be printed  
                // infinite times  
                Console.WriteLine("I am stuck in a rut!!! but only this many times = {0}. ", count);
                // Added Count
                count++;

                if (count > 10)
                {
                    break;
                }
            }

            // PART THREE
            // Loop and Compare

            // Step one
            int j = 0;

            do
            {
                Console.WriteLine("j = {0}", j);
                j++;

                if (j > 5)
                    break;
            }

            while (j < 10);

            // Step two
            for (int k = 0; k <= 12; k++)
                Console.WriteLine("Value of k: {0}", k);

            // PART FOUR
            // STRING LOOP
            // Create List of Strings
            List<string> namesList = new List<string>() { "John", "Billy", "James", "Susan", "Mary", "Kathy", "Nitu" };

            List<string> namesListLower = namesList.ConvertAll(d => d.ToLower());

            // Ask for user input
            Console.WriteLine("Please enter a name to search for: ");

            //Save User input into a variable
            string searchName = Console.ReadLine();
            string searchNameLower = searchName.ToLower();

            bool isNamePresent = namesListLower.Contains(searchNameLower);

            //Loop search
            if (isNamePresent == true)
                for (int m = 0; m < namesListLower.Count; m++)
                {
                    if (namesListLower[m] == searchNameLower)
                    {
                        Console.WriteLine(" Search Name {0}, Index of {1}", searchNameLower, m);
                        break;
                    }
                }
            else
            {
                Console.WriteLine("Search Name is not in list", searchNameLower);
            }

            Console.ReadLine();

            // PART FIVE
            // STRING LOOP
            // Create List of Strings with Duplicates
            List<string> namesList2 = new List<string>() { "John", "Billy", "James", "Susan", "Mary", "Kathy", "Nitu", "James", "John" };

            List<string> namesListLower2 = namesList2.ConvertAll(d => d.ToLower());

            // Ask for user input
            Console.WriteLine("Please enter a name to search for: ");

            //Save User input into a variable
            string searchName2 = Console.ReadLine();
            string searchNameLower2 = searchName2.ToLower();

            bool isNamePresent2 = namesListLower2.Contains(searchNameLower2);

            //Loop search
            if (isNamePresent2 == true)
                for (int m2 = 0; m2 < namesListLower2.Count; m2++)
                {
                    if (namesListLower2[m2] == searchNameLower2)
                    {
                        Console.WriteLine(" Search Name {0}, Index of {1}", searchNameLower2, m2);
                    }
                }
            else
            {
                Console.WriteLine("Search Name is not in list", searchNameLower2);
            }

            Console.ReadLine();

            // PART SIX
            // STRING LOOP
            // Create List of Strings with Duplicates
            List<string> namesList3 = new List<string>() { "House", "Barn", "Fence", "Gate", "House", "Shed", "Garage", "Gate", "Drive" };
            // set all stings to lower
            List<string> namesListLower3 = namesList3.ConvertAll(d => d.ToLower());
            var hashset = new HashSet<string>();
            foreach(var name in namesListLower3)
            {
                Console.WriteLine(name);
                if (!hashset.Add(name))
                {
                    Console.WriteLine("This word is a duplicate: {0}", name);
                }

            }
            Console.ReadLine();

        }
    }
}