using System.Data;

public class Entry {

    private string _prompt;
    private string _dateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
    private string _response;

    public void RandomPrompt() {
        // Generate random prompt from a list of prompts
        Prompts prompts = new Prompts(); 
        _prompt = prompts.RandomPrompt();
        Console.WriteLine(_prompt);
    }

    public void GetResponse() {
        //get user input
        _response = Console.ReadLine();
    }

     public void LoadEntryAccess(string[] entry) { // allow journal to load saved entries
        _dateTime = entry[0];
        _prompt = entry[1];
        _response = entry[2];
    }


    public void DisplayEntry() {
        Console.WriteLine($"Date: {_dateTime} \nPrompt: {_prompt} \nJournal Entry: \n{_response}\n");
    }


    public List<string> SaveEntry() {
        List <string> entry = [_dateTime, _prompt, _response];
        return entry;
    }
}