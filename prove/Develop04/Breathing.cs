using System.ComponentModel;

class Breathing : MindfullnessActivity
{

    public Breathing(int duration)
    : base("Breathing", duration,
    "Welcome to the Breathing Activity!\n\nDescription: This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.\n\nPrepare to begin...\n") //start message
    {

    }


    public void Display()
    {
        Console.WriteLine("Breathe in slowly (5 seconds)...");
        this.PauseAnimation(5, 1);
        Console.WriteLine("Breathe out slowly (5 seconds)...");
        this.PauseAnimation(5, 1);
    }

}