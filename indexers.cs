using System;

namespace IndexerExample
{
    class Student
    {
        private string[] subjects = new string[3];

        public string this[int index]
        {
            get { return subjects[index]; }
            set { subjects[index] = value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();

            s[0] = "C#";
            s[1] = "Python";
            s[2] = "Flutter";

            Console.WriteLine("Subjects:");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(s[i]);
            }

            Console.ReadKey();
        }
    }
}