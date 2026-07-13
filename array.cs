using System;

namespace ArrayExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] hobbies = { "Playing Volleyball", "Stock Trading", "Learning C#" };

            Console.WriteLine("Name: Pravin");
            Console.WriteLine("My Hobbies:");

            for (int i = 0; i < hobbies.Length; i++)
            {
                Console.WriteLine(hobbies[i]);
            }

            Console.ReadKey();
        }
    }
}