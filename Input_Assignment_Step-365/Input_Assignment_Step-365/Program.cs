using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Input_Assignment_Step_365
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter any number: ");
            double number = Convert.ToDouble(Console.ReadLine());
            File.WriteAllText(@"C:\Users\breev\OneDrive\Desktop\Basic_C#_Programs\Input_Assignment_Step-365\log.txt", Convert.ToString(number));
            string readText = File.ReadAllText(@"C:\Users\breev\OneDrive\Desktop\Basic_C#_Programs\Input_Assignment_Step-365\log.txt");
            Console.WriteLine(readText);

            Console.ReadLine();
        }
    }
}
