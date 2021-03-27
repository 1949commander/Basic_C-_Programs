using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Opt_Params_step_280
{
    class Program
    {
        static void Main(string[] args)
        {


            // Request User Input
            Console.WriteLine("Enter a whole number");
            string inputOne = (Console.ReadLine());
            Console.WriteLine("Optional: Enter another whole number");
            string inputTwoOpt = (Console.ReadLine());

            // Instanciate
            Math_Op mathObj = new Math_Op();

            // Call method
            if (inputTwoOpt == "")
            {
                //Convert String Input to int
                int numOne = Convert.ToInt32(inputOne);
                int numTwoOpt = 0; // Default Value

                mathObj.MathMethod(numOne, numTwoOpt);
            }

            else
            {
                //Convert String Input to int
                int numOne = Convert.ToInt32(inputOne);
                int numTwoInt = Convert.ToInt32(inputTwoOpt);

                mathObj.MathMethod(numOne, numTwoInt);
            }

                            
            Console.ReadLine();
        }
    }
}
