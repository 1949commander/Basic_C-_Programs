using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step_263_sting_and_int
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create List of Intergers
            List <int> listOfIntergers = new List<int>() { 2, 5, 8, 11, 16, 32 };

            // Ask user to enter a number to divde by
            Console.WriteLine("Please enter a number: ");


            // Try Catch Block
            try
            {
            int userInput = Convert.ToInt32(Console.ReadLine());
            int resultValue = 0;

            // For Loop
            for (int i = 0; i < listOfIntergers.Count; i++)
            {
                resultValue = listOfIntergers[i] / userInput;
                Console.WriteLine("List Number " + listOfIntergers[i] + " Divided by " + userInput + " Equals " + resultValue);
            }

            // Catch Errors
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("End");
            }
            Console.ReadLine();
        }
    }
}
