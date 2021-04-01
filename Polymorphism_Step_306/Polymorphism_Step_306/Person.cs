using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Step_306
{
     // Create Abstract Class
    public abstract class Person
    {
        // Create Abstract Properties
        public string firstName
        { get; set; }
        public string lastName
        { get; set; }
        // Create Abstract Method
        public abstract void SayName();
    }
}
