using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_233
{
    class Program
    {
        static void Main(string[] args)
        {
            // String variables
            string text_1 = "How are you today?";
            string text_2 = "I am ok. How are you?";
            string text_3 = "I am doing wonderful!";

            //Concatinate strings
            string fullSentence = text_1 + " \n " + text_2 + " \n " + text_3;

            //Convert string to Upper Case
            string uppercase_FullSentance = fullSentence.ToUpper();
            
            //Write strings created above to console
            Console.WriteLine("Greeting: {0}", fullSentence);
            Console.WriteLine("Greeting in upper case: {0}", uppercase_FullSentance);

            //Create string builder
            StringBuilder strBuilder = new StringBuilder("The weather today is:");
            strBuilder.AppendLine("\n\tIs Sunny and Warm");
            strBuilder.AppendLine("\n\twith south east winds, ");
            strBuilder.AppendLine("\n\tvariable from 10-15 mph.");
            strBuilder.AppendLine("\n\twith high temperature in the 70's.");

            //Write contents of string builder to console
            Console.WriteLine(strBuilder);
                
        
            Console.ReadLine();
        }
    }
}
