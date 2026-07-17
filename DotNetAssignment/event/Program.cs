using System;

class Button
{
    // Declare an event
    public event EventHandler ButtonClicked;

    public void Click()
    {
        Console.WriteLine("Button clicked.");
        ButtonClicked?.Invoke(this, EventArgs.Empty);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Button button = new Button();

        // Subscribe to the event
        button.ButtonClicked += OnButtonClicked;

        // Raise the event
        button.Click();

        Console.ReadLine();
    }

    static void OnButtonClicked(object sender, EventArgs e)
    {
        Console.WriteLine("Event handled successfully.");
    }
}
