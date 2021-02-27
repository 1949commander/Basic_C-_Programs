using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Report_PG_140
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Variables here
            string titleName = "The Tech Academy.";
            string subTitleName = "Student Daily Report.";
            string yourName;
            string yourCourse;
            int pageNumber;
            bool needHelp = true;
            string positiveExperiences;
            string feedbackSpecific;
            int hoursStudied;
            string closingStatement = "Thank you for your answers. An instructor will"
                + " respond to this shortly. Have a great day!";
            // Program begins here
            Console.WriteLine(titleName);
            Console.WriteLine(subTitleName);
            Console.WriteLine("Enter you full name:");
            yourName = Console.ReadLine();
            Console.WriteLine("Enter the course name you are on: ");
            yourCourse = Console.ReadLine();
            Console.WriteLine("Enter your page number: ");
            pageNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false.\"");
            needHelp = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics ");
            positiveExperiences = (Console.ReadLine());
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific. ");
            feedbackSpecific = (Console.ReadLine());
            Console.WriteLine("How many hours did you study today? ");
            hoursStudied = (Convert.ToInt32(Console.ReadLine()));
            // Program Data Write out
            Console.WriteLine("Full Name: " + yourName);
            Console.WriteLine("Course Name: " + yourCourse);
            Console.WriteLine("Current Page Number: " + pageNumber);
            Console.WriteLine("Do you need help with anything? " + needHelp);
            Console.WriteLine("Were there any positive experiences you’d like to share? " + positiveExperiences);
            Console.WriteLine("Is there any other feedback you'd like to provide? " + feedbackSpecific);
            Console.WriteLine("How many hours did you study today? " + hoursStudied);
            Console.WriteLine(closingStatement);
            // Stop program so it can be read
            Console.ReadLine();
        }
    }
}
