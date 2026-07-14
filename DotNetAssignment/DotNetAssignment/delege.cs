using System;

class Student
{
    public delegate void ResultHandler(string message);

    public event ResultHandler ResultPublished;

    public void PublishResult()
    {
        Console.WriteLine("Result is being published...");

        if (ResultPublished != null)
        {
            ResultPublished("Congratulations! You passed the exam.");
        }
    }
}

class Program
{
    static void ShowResult(string message)
    {
        Console.WriteLine(message);
    }

    static void Main()
    {
        Student student = new Student();

        student.ResultPublished += ShowResult;

        student.PublishResult();

        Console.ReadKey();
    }
}