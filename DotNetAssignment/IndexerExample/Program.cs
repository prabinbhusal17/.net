using System;

class Library
{
    private string[] books = new string[4];

    public string this[int index]
    {
        get { return books[index]; }
        set { books[index] = value; }
    }
}

class Program
{
    static void Main()
    {
        Library library = new Library();

        library[0] = "C Programming";
        library[1] = "Data Structure";
        library[2] = "Operating System";
        library[3] = "Database";

        Console.WriteLine("Books in Library:");

        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine(library[i]);
        }
    }
}