using System;

class Program
{
    static void Main()
    {
        int[,,] marks =
        {
            {
                {80, 85},
                {75, 90}
            },
            {
                {88, 92},
                {78, 81}
            }
        };

        Console.WriteLine("Student Marks:");

        for (int i = 0; i < marks.GetLength(0); i++)
        {
            Console.WriteLine("Class " + (i + 1));

            for (int j = 0; j < marks.GetLength(1); j++)
            {
                for (int k = 0; k < marks.GetLength(2); k++)
                {
                    Console.WriteLine("Student " + (j + 1) +
                                      " Subject " + (k + 1) +
                                      " = " + marks[i, j, k]);
                }
            }

            Console.WriteLine();
        }
    }
}