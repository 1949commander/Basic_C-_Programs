using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    // Create Struct Number
    public struct Number
    {
        // Create Property Amount
        public Number (decimal amount)
        {
            Amount = amount;
        }

        public decimal Amount { get; set; }

    }
    class Program
    {
        static void Main()
        {
            // Instantiate Number
            Number myNum = new Number();

            // Assign Value to Amount
            myNum.Amount = 3.875m;

            // Print Amount
            Console.WriteLine("Amount = {0}", myNum.Amount);
            Console.ReadLine();
        }

    }
