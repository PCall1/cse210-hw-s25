
using System.ComponentModel;

class Scripture
{
    private string _reference;
    private List<Word> _listOfWords;
    private Random _random = new Random();


    public Scripture(string reference, string verses)
    {
        _reference = reference; // Initialize _reference
        _listOfWords = new List<Word>(); //create list for individual words
        string[] words = verses.Split(' '); //Break string into individual words
        foreach (string word in words) // For each word in the verses...
        {
            _listOfWords.Add(new Word(word)); // ...Add word to list
        }
    }

    public void Display()
    {
        Console.Clear();
        Console.WriteLine(_reference);

        int lineLength = 0;
        int maxLineLength = 60; // Set max characters per line
        foreach (Word word in _listOfWords)
        {
            string displayWord = word.Display();
            
            if (lineLength + displayWord.Length + 1 > maxLineLength) // includes whole words instead of cutting off mid word
            {
                Console.WriteLine(); // New line when 60 characters is exceeded
                lineLength = 0; // Reset line length for new line
            }
            Console.Write(displayWord + " ");
            lineLength += displayWord.Length + 1; // +1 adds character count for space at the end of the word
        }
        Console.WriteLine(); // End with a newline for formatting
    }

    public void HideWords()
    {
        // If there are fewer than 3 words left, returns number of words left instead of "3", and the function won't loop forever
        int wordsToHide = Math.Min(3, _listOfWords.Count(word => !word.IsHidden()));

        int count = 0;
        while (count < wordsToHide)
        {
            int index = _random.Next(_listOfWords.Count); // Pick a word from the list...
            if (!_listOfWords[index].IsHidden()) //...if not already hidden...
            {
                _listOfWords[index].Hide(); //...hide the randomly chosen word
                count++;
            }
        }
    }

    public bool HiddenCompletely()
    {
        foreach (Word word in _listOfWords)
        {
            if (!word.IsHidden()) // If ANY word NOT is hidden...
            {
                return false; //...then return false
            }
        }
        return true; // All words are hidden
    }
}