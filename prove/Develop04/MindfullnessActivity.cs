using System.Timers;
using System;
class MindfullnessActivity
{
    private string _name;
    private int _duration;
    private string _startMessage;
    private string _endMessage;


    public MindfullnessActivity(string name, int duration, string startMessage)
    {
        _name = name;
        _duration = duration;
        _startMessage = startMessage;
        _endMessage = $"Good job! You did the {_name} activity for at least {_duration} seconds!";

    }


    public void DoForDuration(Action action, int duration)
    {

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);
        DateTime currentTime;

        do
        {
            action();

            currentTime = DateTime.Now;
        } while (currentTime < futureTime);
    }

    public void DisplayStartMessage()
    {
        Console.WriteLine(_startMessage);
    }

    public void DisplayEndMessage()
    {
        Console.WriteLine(_endMessage);
    }

    public void PauseAnimation(int seconds, int type)
    {
        if (type == 0)
        {
            for (int i = 0; i < seconds; i++)
            {
                //Spinner
                Console.Write("|");
                Thread.Sleep(250);
                Console.Write("\b \b"); // Erase the last character
                Console.Write("\\"); // Write the \ character
                Thread.Sleep(250);
                Console.Write("\b \b");
                Console.Write("-"); 
                Thread.Sleep(250);
                Console.Write("\b \b");
                Console.Write("/"); 
                Thread.Sleep(250);
                Console.Write("\b \b");

            }
        }
        
        else if (type == 1)
        {
            //Countdown
            Console.Write("5");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("4");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("3");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("2");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("1");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}