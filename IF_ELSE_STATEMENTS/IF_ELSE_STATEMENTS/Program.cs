using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF_ELSE_STATEMENTS
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 7;
            int num2 = 12;
            int num3 = 2;
            int num4 = 8;

            string result = num1 > num3 ? "num1 is greater than num3" : "num1 is not greater than num3";
            Console.WriteLine(result);

            //if (num1 <= num2 && num4 >= num3)
            //{
            //    Console.WriteLine("The if statement ran. ");
                
            //}
           
            //else
            //{
            //    Console.WriteLine("The else statement ran.");
            //}

            Console.ReadLine();
        }
    }
}
