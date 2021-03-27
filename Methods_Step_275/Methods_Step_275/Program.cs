using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Step_275
{
    class Program
    {
        static void Main(string[] args)
        {
            // User Input Request
            Console.WriteLine("Please enter a  whole number to perform math operations on:");
            int userInput = Convert.ToInt32(Console.ReadLine());

            // Instantiate 
            Math mathOps = new Math();

            // Call Methods
            int valueOne = mathOps.MathOne(userInput);
            int valueTwo = mathOps.MathTwo(userInput);
            int valueThree = mathOps.MathThree(userInput);

            // Print Results
            Console.WriteLine("Call MathOne, User Input Value is: {0} Result Value is {1}.",  userInput , valueOne);
            Console.WriteLine("Call MathTwo, User Input Value is: {0} Result Value is {1}.", userInput , valueTwo);
            Console.WriteLine("Call MathThree, User Input Value is: {0} Result Value is {1}.", userInput , valueThree);

            Console.ReadLine();
        }
    }
}
