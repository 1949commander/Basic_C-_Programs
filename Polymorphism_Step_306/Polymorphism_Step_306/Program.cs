using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Step_306
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciate Employee Class Object
            Employee SampleEmployee = new Employee();
            Employee IQuittable = new Employee();

            // Initiate New Sample Employee
            SampleEmployee.firstName = "Sample";
            SampleEmployee.lastName = "Student";
            // Call Method
            SampleEmployee.SayName();
            // Call Interface Method
            IQuittable.Quit();
        }
    }
}
