using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method_Step_279
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inputs
            int v1 = 8;
            float v2 = 344.56f;
            string v3 = "45";

            // Instantiate
            MathOPS myObj = new MathOPS();

            // Call Method with different inputs
            int resultOne = myObj.OverloadMath(v1);
            int resultTwo = myObj.OverloadMath(v2);
            int resultThree = myObj.OverloadMath(v3);
            
            // Print Results
            Console.WriteLine("Results of intAddInt: {0}", resultOne);
            Console.WriteLine("Results of intAddInt: {0}", resultTwo);
            Console.WriteLine("Results of intAddInt: {0}", resultThree);
            Console.ReadLine();
        }
    }
}
