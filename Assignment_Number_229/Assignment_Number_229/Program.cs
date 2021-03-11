using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Number_229
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create and Set Variable
            int i = 10;

            // While loop
            while (i < 15)
            {
                Console.WriteLine("Value of i: {0}", i);
                i++;
            }
            // Create and Set Variable
            int a = 1;

            // Do While loop
            do
            {
                Console.WriteLine("Value of a: {0}", a);
                a += 1;
            }
            while (a < 20);


            Console.ReadLine();
        }
    }
}
