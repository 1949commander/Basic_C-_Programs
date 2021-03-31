using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Lect
{
    // Create Abstract Class
    public abstract class Person
    {
        // Create Abstract Properties
        public abstract string firstName
        { get; set; }
        public abstract string lastName
        { get; set; }
        // Create Abstract Method
        public abstract void SayName();
    }

}
