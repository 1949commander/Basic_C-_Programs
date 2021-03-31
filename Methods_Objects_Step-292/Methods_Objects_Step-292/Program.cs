using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Objects_Step_292
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate Object
            Employee sampleEmployee = new Employee();
            // Initialize Object
            sampleEmployee.FirstName = "Sample"; 
            sampleEmployee.LastName = "Student";
            // Call Super Class Method
            sampleEmployee.SayName();

        }
    }
}
