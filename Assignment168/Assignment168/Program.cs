using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment168
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age? ");
            int yourAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI? True or False");
            bool hadDui = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("How many speeding tickets do you have? ");
            int numberSpeedTickets = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(yourAge);
            //Console.WriteLine(hadDui);
            //Console.WriteLine(numberSpeedTickets);

            bool yourAgeTrue = yourAge > 15;
            bool hadDuiTrue = hadDui != true;
            bool numberSpeedTicketsTrue = numberSpeedTickets <= 3;
            bool qualifiedTrue = yourAgeTrue && hadDuiTrue && numberSpeedTicketsTrue;

            //Console.WriteLine(yourAgeTrue);
            //Console.WriteLine(hadDuiTrue);
            //Console.WriteLine(numberSpeedTicketsTrue);

            Console.WriteLine("Qualified? ");
            Console.WriteLine(qualifiedTrue);

            Console.ReadLine();
        }
    }
}
