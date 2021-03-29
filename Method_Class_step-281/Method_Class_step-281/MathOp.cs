using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Class_step_281
{
    class MathOp
    {
        // Create method
        public void MyMethod(int numOne, int numTwo)
        {
            //Math Function
            int mathOne = numOne * 9;

            //Print Results
            Console.WriteLine("NumOne times 9 = {0}", mathOne);
            Console.WriteLine("Value of other number is: {0}", numTwo);
        }
    }
}