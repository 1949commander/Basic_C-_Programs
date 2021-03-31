using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Lect
{
    // Create New Class using Inheratance from Abstract Class
    public class Employee : Person
    {
        private string firstname = "";
        private string lastname = "";

        public override string firstName // Declare abstract firstName property:
        {
            get
            {
                return firstname;
            }
            set
            {
                firstname = value;
            }
        }

        public override string lastName // Declare abstract lastName property:
        {
            get
            {
                return lastname;
            }
            set
            {
                lastname = value;
            }
        }
        public override void SayName() // Create SayName Method in Employee class.
        {
            Console.WriteLine(firstName + " " + lastName);
            Console.ReadLine();
        }
    }
}
