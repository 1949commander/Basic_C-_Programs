using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPartFour_254
{
    class Program
    {
        static void Main(string[] args)
        {
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
            Console.WriteLine(isNamePresent);
                const bool V = false;

            if (isNamePresent == V)
            { 
                do
                {
                    Console.WriteLine("Search Name is not in list");
                    // Ask for new user input
                    Console.WriteLine("Please enter a different name to search for: ");
                    searchName = Console.ReadLine();
                    searchNameLower = searchName.ToLower();
                    isNamePresent = namesListLower.Contains(searchNameLower);
                    Console.WriteLine(isNamePresent);
                }
                while (isNamePresent == V);
            }
            //if(isNamePresent == true)
            //{
                
            //    {
            //        if (namesListLower[m] != searchNameLower)
            //        {
            //            for (int m = 0; m < namesListLower.Count; m++)
            //        }
            //        else
            //        {
            //            Console.WriteLine(" Search Name {0}, Index of {1}", searchNameLower, m);
            //        }
            //        break;
            //    }
            //}

            
            Console.ReadLine();
        }
    }  
}
