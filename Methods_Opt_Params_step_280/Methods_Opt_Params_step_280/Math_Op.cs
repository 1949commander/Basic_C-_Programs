using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Opt_Params_step_280
{
    class Math_Op
    {
        // Method
        public void MathMethod(int numOne, int numTwoOpt)
        {
            // Method Statenebt
            int resultValue = (numOne + numTwoOpt) * 2;
            // Print Results
            Console.WriteLine("Results: {0}", resultValue);
        }
    }
}
