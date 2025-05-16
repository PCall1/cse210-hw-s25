//Generate random prompt from a list of prompts
using System;

public class Prompts
{
    string[] prompts = [ // list of prompts
        "What was the best part of your day?",
        "What's one thing you learned today?",
        "What was something challenging today?",
        "What are you grateful for today?",
        "How did you recognize the Lord's hand today?",
        "Did you do anything fun today? What was it? or Why not?",
        "Who was one new person you met or got to know today?",

    ] ;
    
    public string RandomPrompt() {
        Random random = new Random();
        int index = random.Next(prompts.Length);
        return prompts[index];
    }
}