using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overload_Step_313
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee_one = new Employee
            {
                FirstName = "John",
                LastName = "Smith",
                ID = 1002
            };

            Employee employee_two = new Employee
            {
                FirstName = "Mary",
                LastName = "Jones",
                ID = 1003
            };

            Console.WriteLine(employee_one.FirstName + " " + employee_one.LastName + " " + employee_one.ID);
            Console.WriteLine(employee_two.FirstName + " " + employee_two.LastName + " " + employee_two.ID);
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
