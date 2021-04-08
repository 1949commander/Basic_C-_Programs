using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Assignment_Step_337
{    
    public class Employee 
    {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
    }


    public class Program 
    { 

        static void Main(string[] args)
        {
            List<Employee> empList = new List<Employee>();

            empList.Add(new Employee()
            {Id = 00, FirstName = "John", LastName = "Nobody"});
            empList.Add(new Employee()
            { Id = 01, FirstName = "William", LastName = "Smith" });
            empList.Add(new Employee()
            { Id = 02, FirstName = "Jerry", LastName = "Johnson" });
            empList.Add(new Employee()
            { Id = 03, FirstName = "Joe", LastName = "Smith" });
            empList.Add(new Employee()
            { Id = 04, FirstName = "Joe", LastName = "Kerry" });
            empList.Add(new Employee()
            { Id = 05, FirstName = "Jane", LastName = "Doe" });
            empList.Add(new Employee()
            { Id = 06, FirstName = "Susie", LastName = "Jacobs" });
            empList.Add(new Employee()
            { Id = 07, FirstName = "Bob", LastName = "Jones" });
            empList.Add(new Employee()
            { Id = 08, FirstName = "Nitu", LastName = "Gupta" });
            empList.Add(new Employee()
            { Id = 09, FirstName = "Beth", LastName = "Cain" });
            empList.Add(new Employee()
            { Id = 10, FirstName = "Mary", LastName = "VanJones" });
            empList.Add(new Employee()
            { Id = 11, FirstName = "Daniel", LastName = "Keller" });
            empList.Add(new Employee()
            { Id = 12, FirstName = "Marty", LastName = "Swick" });

            // Print all employees whos first name is "Joe"
            Console.WriteLine("Print all employees with the first name of \"Joe \" ");
            Console.WriteLine(); // For Blank Line
            foreach (var data in empList)
            {
            // Using If Statement
                if (data.FirstName == "Joe")
                {
                    Console.WriteLine("My ID is {0} First Name is {1} and Last Name is {2}", data.Id, data.FirstName, data.LastName);
                }
            }
            Console.WriteLine(); // For Blank Line

            // Print all employees whos first name is "Joe"
            Console.WriteLine("Print all employees with the first name of \"Joe \" ");
            Console.WriteLine(); // For Blank Line
            //Lambda Expression
            foreach (Employee data in empList.FindAll(e => e.FirstName == "Joe").ToList())
            {
                Console.WriteLine("My ID is {0} First Name is {1} and Last Name is {2}", data.Id, data.FirstName, data.LastName);
            }
            Console.WriteLine(); // For Blank Line

            // Print all employees whos ID is greater than "5"
            Console.WriteLine("Print all employees whos ID is greater than \"5\"");
            Console.WriteLine(); // For Blank Line
            //Lambda Expression
            foreach (Employee data in empList.FindAll(e => (e.Id > 5)).ToList())
            {
                Console.WriteLine("My ID is {0} First Name is {1} and Last Name is {2}", data.Id, data.FirstName, data.LastName);
            }



            Console.ReadLine();
        }
    }


}
