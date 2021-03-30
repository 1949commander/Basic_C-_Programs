using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Assignment_Step_285
{
    class Program
    {
        
        static void Main(string[] args)
        {
            // User Input Request
            Console.WriteLine("Enter a whole number: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            // Instantiate Class 1
            Class1 class1 = new Class1();

            // Call First Method
            class1.MethodOpInt(userInput);

            // Call Method with outputs
            class1.MethodOutParm(out int num1, out int num2, out string name);
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(name);

            // Call Overloaded Method   
            int myNum1 = class1.AdditionMethod(7, 4);
            double myNum2 = class1.AdditionMethod(6.7, 8.61);
            Console.WriteLine(myNum1);
            Console.WriteLine(myNum2);

            // Call Static Class and Method
            double multResult = Class_Static.MultiplyDouble(8.99, 45.90);
            Console.WriteLine(multResult);

            Console.ReadLine();

        }
    }
}
