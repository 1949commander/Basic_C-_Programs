using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment185
{
    class Program
    {
        static void Main(string[] args)
        {
            // Check to see if package weight is under maximum weight.
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight: ");
            int packWeight = Convert.ToInt32(Console.ReadLine());
            if (packWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                // Enter Package Dimensions and store data
                Console.WriteLine("Please enter the package width:");
                int packWidth = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package height:");
                int packHeight = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package length:");
                int packLength = Convert.ToInt32(Console.ReadLine());

                // Add package dimensions 
                int totalDim = packWidth + packHeight + packLength;

                // Check to see if total package dimensions are under maximum
                if (totalDim > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }

                // Create Quote
                else
                {
                    int shipQuote = ((packWidth * packHeight * packLength) * packWeight) / 100;
                    string estQuote = String.Format("Your estimated total for shipping this package is: {0:C}", shipQuote);

                    // Display Quote Estimate to window
                    Console.WriteLine(estQuote +"\nThank you!");
                }
            }
            Console.ReadLine();
        }
    }
}
