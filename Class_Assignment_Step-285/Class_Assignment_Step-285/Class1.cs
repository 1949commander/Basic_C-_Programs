using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Assignment_Step_285
{
    class Class1
    {
        // Void Method
        public void MethodOpInt(int inputOne)
        {
            Console.WriteLine(inputOne / 2);
            Console.ReadLine();
        }

        // Void Method with Output Parameters
        public void MethodOutParm(out int num1, out int num2, out string name)
        {
            num1 = 56;
            num2 = 5667;
            name = "John";
        }

        // Overloaded Method with return values
        public int AdditionMethod(int x, int y)
        {
            return x + y;
        }

        public double AdditionMethod(double x, double y)
        {
            return x + y;
        }
    }
}
