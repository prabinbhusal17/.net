using System;

class Program
{
    static void Main()
    {
        string[][] students = new string[3][];

        students[0] = new string[] { "Ram", "Sita" };
        students[1] = new string[] { "Hari", "Gita", "Laxman" };
        students[2] = new string[] { "Rita", "Shyam", "Bina", "Kiran" };

        Console.WriteLine("Student List:");

        for (int i = 0; i < students.Length; i++)
        {
            Console.Write("Class " + (i + 1) + ": ");

            for (int j = 0; j < students[i].Length; j++)
            {
                Console.Write(students[i][j] + " ");
            }

            Console.WriteLine();
        }
    }
}