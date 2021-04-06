using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters_Step_317
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate generic with String
            Employee<string> names = new Employee<string>();

            names.Things.Add("Joe");
            names.Things.Add("James");
            names.Things.Add("Jane");
            names.Things.Add("Susie");

            foreach(string i in names.Things)
            {
                Console.WriteLine(i);
            }

            //instantiate generic with Int
            Employee<int> index = new Employee<int>();

            index.Things.Add(1);
            index.Things.Add(2);
            index.Things.Add(3);
            index.Things.Add(4);

            foreach (int i in index.Things)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();

        }
    }
}
