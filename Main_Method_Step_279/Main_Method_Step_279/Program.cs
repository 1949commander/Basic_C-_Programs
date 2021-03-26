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

            // Call Methods
            MathOPS intAddInt = new MathOPS(v1, v2, v3);
            MathOPS decSubInt = new MathOPS(v1, v2, v3);
            MathOPS strMultInt = new MathOPS(v1, v2, v3);
            
            // Print Results
            Console.WriteLine("Results of intAddInt:" + intAddInt.V1);
            Console.WriteLine("Results of decSubInt:" + decSubInt.V2);
            Console.WriteLine("Results of strMultInt:" + strMultInt.V3);
            Console.ReadLine();
        }
    }
}
