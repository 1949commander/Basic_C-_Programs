using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment159
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Enter Hourly Rate? ");
            int hourlyRate1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter hours per week? ");
            int hoursWeek1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Person 2");
            Console.WriteLine("Enter Hourly Rate? ");
            int hourlyRate2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter hours per week? ");
            int hoursWeek2 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Annual salary of person 1:");
            int annualSalary1 = (int)(hourlyRate1 * hoursWeek1 * 52);
            string annualSalaryFmt1 = string.Format("{0:n0}", annualSalary1);
            Console.WriteLine(annualSalaryFmt1);

            Console.WriteLine("Annual salary of person 2:");
            int annualSalary2 = (int)(hourlyRate2 * hoursWeek2 * 52);
            string annualSalaryFmt2 = string.Format("{0:n0}", annualSalary2);
            Console.WriteLine(annualSalaryFmt2);

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(annualSalary1 > annualSalary2);

            Console.ReadLine();
        }
    }
}
