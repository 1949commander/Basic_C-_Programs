using System;

namespace methods_classes
{
    class Program
    {
        static void Main()
        {
            // User Input Request
            Console.WriteLine("Please enter a  whole number to perform math operations on:");
            int userInput = Convert.ToInt32(Console.ReadLine());

            // Call Methods
            Math mathOne = new Math(userInput);
            Math2 mathTwo = new Math2(userInput);
            Math3 mathThree = new Math3(userInput);

            // Print Results
            Console.WriteLine("Input value " + userInput + " Call Method Math, Results in " + mathOne.resultOne);
            Console.WriteLine("Input value " + userInput + " Call Method Math2, Results in " + mathTwo.resultTwo);
            Console.WriteLine("Input value " + userInput + " Call Method Math3, Results in " + mathThree.resultThree);
            Console.ReadLine();
        }
    }
}
