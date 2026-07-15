using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Program Started");

        await DownloadData();

        Console.WriteLine("Program Finished");
    }

    static async Task DownloadData()
    {
        Console.WriteLine("Downloading data...");

        await Task.Delay(3000);

        Console.WriteLine("Download Complete");
    }
}