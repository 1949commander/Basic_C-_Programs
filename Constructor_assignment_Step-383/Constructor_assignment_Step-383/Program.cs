using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_assignment_Step_383
{
    public class NewEmployee
    {
        // Create Variables
        public string firstName;
        public string lastName;
        public string empID;
        public string companyName;
        //Create the Constructor
        public NewEmployee() : this("Default firstName", "Default lastName")
        {
            Console.WriteLine("Reserving new record for the upcoming employee.");
        }
        public NewEmployee(string firstName) : this(firstName, "Default lastName")
        {
            this.firstName = firstName;
            Console.WriteLine("Creating new record for the upcoming employee, with firstName!");
        }
        public NewEmployee(string firstName, string lastName) : this(firstName, lastName, "Default empID", "Default companyName")
        {
            this.lastName = lastName;
            this.firstName = firstName;
            Console.WriteLine("Creating new record for the upcoming employee, with firstName and lastName!");
        }
        public NewEmployee(string firstName, string lastName, string empID, string companyName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.empID = empID;
            this.companyName = companyName;

            Console.WriteLine("Creating new record for the upcoming employee, with firstName, lastName, empID and companyName!");
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            const string companyName = "My Special Company";
            var specialNumber = "1999.097";

            //// Creates a New Employee with no data
            Console.WriteLine("First construct!");
            NewEmployee a = new NewEmployee();
            //// Creates a New Employee with First Name
            Console.WriteLine("Second construct!");
            NewEmployee b = new NewEmployee("Daniel");
            // Creates a New Employee with First Name, Last Name, Employee ID and Company Name
            Console.WriteLine("Third construct!");
            NewEmployee c = new NewEmployee("Daniel", "Szabo", specialNumber, companyName);

            Console.ReadKey();
        }
            
    }
}
