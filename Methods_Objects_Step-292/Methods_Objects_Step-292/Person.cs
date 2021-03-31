using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Objects_Step_292
{
    public class Person //Base class "Parent" Super Class
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }


        public void SayName() //Super Class Method
        {
            string FullName = FirstName +" "+ LastName;
            Console.WriteLine(FullName);
            Console.ReadLine();
        }
    }
}
