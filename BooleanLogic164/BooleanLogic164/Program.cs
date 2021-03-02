using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic164
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 7;
            int num2 = 12;
            int num3 = 23;
            int num4 = 14;
            int num5 = 8;
            int num6 = 5;

            bool result = (num1 < num2 && (num3 < num4 || num5 < num6));
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
