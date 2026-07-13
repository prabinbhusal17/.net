using System;
using System.Collections.Generic;

namespace CollectionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> skills = new List<string>();

            skills.Add("C#");
            skills.Add("Python");
            skills.Add("Flutter");
            skills.Add("GitHub");

            Console.WriteLine("My Skills:");

            foreach (string skill in skills)
            {
                Console.WriteLine(skill);
            }

            Console.ReadKey();
        }
    }
}