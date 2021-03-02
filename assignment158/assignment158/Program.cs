using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment158
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            double input1 = Convert.ToDouble(Console.ReadLine());
            double result1 = 50 * input1;
            Console.WriteLine("Result is: 50 times " + input1 + (" = ") + result1);

            double result2 = 25 + input1;
            Console.WriteLine("Result is: 25 plus " + input1 + (" = ") + result2);

            double result3 = input1 / 12.5;
            Console.WriteLine("Result is: " + input1 + (" divided by 12.5 = ") + result3);

            bool result4 = input1 > 50;
            Console.WriteLine("Is " + input1 + " greater than 50? " + result4);

            int result5 = (int)(input1 % 7);
            int result6 = (int)(input1 / 7);
            Console.WriteLine(input1 + " divided by 7 is: " + result6);
            Console.WriteLine("The remainder is: " + result5);

            Console.ReadLine();
        }
    }
}
