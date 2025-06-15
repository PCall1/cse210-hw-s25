using System.ComponentModel;

class Listing : MindfullnessActivity
{
    List<string> _prompt =
    [
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    ];
    int _count = 0;


    public Listing(int duration)
    : base("Listing Activity", duration,
    "Welcome to the Listing Activity!\n\nDescription: This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.\n\nPrepare to begin...\n") //start message
    {

    }


    public void Display()
    {
        Random random = new Random();

        int index = random.Next(_prompt.Count);
        string prompt = _prompt[index];
        Console.WriteLine(prompt);

        PauseAnimation(5, 1);

        Console.WriteLine("Begin listing");
    }

    public void GetResponse()
    {
        _count++;
        Console.ReadLine();
    }

    public string GetEndCount()
    {
        string end = $"You listed {_count} items.\n";
        return end;
    }
}