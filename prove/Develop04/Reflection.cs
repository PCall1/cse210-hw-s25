class Reflection : MindfullnessActivity
{
    List<string> _prompts =
    [
        "Think of a time when you felt happy. What made you feel that way?",
        "Think of a time when you felt sad. What happened and how did you cope with it?",
        "Think of a time when you felt proud of yourself. What did you do?",
        "Think of a time when you overcame a challenge. What did you learn?",
        "Think of a time when you helped someone else. How did it make you feel?",
        "Think of a time when you learned something new. What was it and how did it change your perspective?",
        "Think of a time when you faced a difficult decision. What did you choose and why?"
    ];
    List<string> _followUpPrompts = [
        "\nWhy do you think this memory is significant to you?",
        "\nHow did this experience shape who you are today?",
        "\nWhat emotions did you feel during this experience?",
        "\nWhat would you do differently if you could go back to that moment?",
        "\nHow can you apply what you learned from this experience to your current life?"
        ];


    public Reflection(int duration)
    : base("Reflection", duration,
    "Welcome to the Reflection Activity!\n\nDescription: This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.\n\nPrepare to begin...\n") //start message
    {
    
    }


    public void Display()
    {       //print random prompt, wait with animation, print follow up, wait with animation
        Random random = new Random();

        int index = random.Next(_prompts.Count);
        string prompt = _prompts[index];
        Console.WriteLine(prompt);

        PauseAnimation(10, 0);

        int index2 = random.Next(_followUpPrompts.Count);
        string followUpPrompt = _followUpPrompts[index2];
        Console.WriteLine(followUpPrompt);

        PauseAnimation(10, 0);
    }
}