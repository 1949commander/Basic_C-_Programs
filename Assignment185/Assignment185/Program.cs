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
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight: ");
            int packWeight = Convert.ToInt32(Console.ReadLine());
            if (packWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                Console.WriteLine("Please enter the package width:");
                int packWidth = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package height:");
                int packHeight = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package length:");
                int packLength = Convert.ToInt32(Console.ReadLine());
                int totalDim = packWidth + packHeight + packLength;

                if (totalDim > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }
                else
                {
                    int shipQuote = ((packWidth * packHeight * packLength) * packWeight) / 100;
                    string estQuote = String.Format("Your estimated total for shipping this package is: {0:C}", shipQuote);
                    Console.WriteLine(estQuote +"\nThank you!");
                }
            }
            Console.ReadLine();
        }
    }
}
