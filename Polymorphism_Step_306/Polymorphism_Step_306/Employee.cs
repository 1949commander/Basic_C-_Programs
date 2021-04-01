using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Step_306
{
    // Create New Class using Inheratance from Abstract Class
    public class Employee : Person, IQuittable
    {
            
        public override void SayName() // Create SayName Method in Employee class.
        {
            Console.WriteLine(firstName + " " + lastName);
            Console.ReadLine();
        }

        public void Quit() // Create Quit Method in Employee Class
        {
            throw new NotImplementedException();
        }
    }
}
