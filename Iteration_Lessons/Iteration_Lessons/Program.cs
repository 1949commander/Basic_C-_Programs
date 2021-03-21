using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration_Lessons
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };

            //for (int i = 0; i < testScores.Length; i++)
            //{
            //    if (testScores[i] > 85)
            //    {
            //        Console.WriteLine("Passsing test score: " + testScores[i]);
            //    }
            //}
            //Console.ReadLine();

            //string[] names = { "Jesse", "Erick", "Daniel", "Adam" };

            //for (int j = 0; j < names.Length; j++)
            //{
            //                    {
            //        Console.WriteLine(names[j]);
            //    }
            //}

            //Console.ReadLine();


            //int[] numberArray = { 300, 75, 420, 380, 225 };

            //for  (int i=0; i < numberArray.Length; i++)
            //{
            //    if (numberArray[i] / 2 >= 150)
            //    {
            //        Console.WriteLine(numberArray[i] + " divided by 2 is greater than or equal to 150. ");
            //    }
            //}
            //Console.ReadLine();

            //List<int> testScores = new List<int>();
            //testScores.Add(98);
            //testScores.Add(99);
            //testScores.Add(81);
            //testScores.Add(72);
            //testScores.Add(70);

            //foreach (int score in testScores)
            //{
            //    if (score > 85)
            //    {
            //        Console.WriteLine("Passing test score:" + score);
            //    }
            //}
            //Console.ReadLine();

            //List<string> names = new List<string>() { "Jesse", "Erik", "Daniel", "Adam" };

            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);

            //}
            //Console.ReadLine();

            List<int> testScores = new List<int>() { 98, 99, 85, 70, 82, 34, 91, 90, 94 };
            List<int> passingScores = new List<int>();

            foreach (int score in testScores)
            {
                if (score > 85)
                {
                    passingScores.Add(score);
                }

            }

            Console.WriteLine(passingScores.Count);

            Console.ReadLine();
        }
    }
}
