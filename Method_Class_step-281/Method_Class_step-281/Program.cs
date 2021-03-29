using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Class_step_281
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciate Method
            MathOp Op1 = new MathOp();

            // Call Method
            Op1.MyMethod(6, 4);
            Op1.MyMethod(numTwo: 9, numOne: 7);
            
            Console.ReadLine();

        }
    }
}
