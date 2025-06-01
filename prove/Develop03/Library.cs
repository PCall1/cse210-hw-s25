
class Library
{
    private List<string> _allReferences =
    [
        "1 Nephi 3:7",
        "2 Nephi 2:25",
        "Mosiah 2:17",
        "Alma 32:26-29",
    ];
    private List<string> _allScriptures =
    [
        "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.",
        "Adam fell that men might be; and men are, that they might have joy.",
        "And behold, I tell you these things that ye may learn wisdom; that ye may learn that when ye are in the service of your fellow beings ye are only in the service of your God.",
        "26 Now, as I said concerning faith- that it was not a perfect knowledge— even so it is with my words. Ye cannot know of their surety at first, unto perfection, any more than faith is a perfect knowledge. \n\n\t27 But behold, if ye will awake and arouse your faculties, even to an experiment upon my words, and exercise a particle of faith, yea, even if ye can no more than desire to believe, let this desire work in you, even until ye believe in a manner that ye can give place for a portion of my words. \n\n\t28 Now, we will compare the word unto a seed. Now, if ye give place, that a seed may be planted in your heart, behold, if it be a true seed, or a good seed, if ye do not cast it out by your unbelief, that ye will resist the Spirit of the Lord, behold, it will begin to swell within your breasts; and when you feel these swelling motions, ye will begin to say within yourselves It must needs be that this is a good seed, or that the word is good, for it beginneth to enlarge my soul; yea, it beginneth to enlighten my understanding, yea, it beginneth to be delicious to me. \n\n\t29 Now behold, would not this increase your faith? I say unto you, Yea; nevertheless it hath not grown up to a perfect knowledge."
    ];


    public Library()
    {

    }

    public void UserChoice()
    {
        Console.WriteLine("Welcome to the Scripture Library!");
        Console.WriteLine("What scripture do you want to memorize?:");
        Console.WriteLine($"1. {_allReferences[0]}");
        Console.WriteLine($"2. {_allReferences[1]}");
        Console.WriteLine($"3. {_allReferences[2]}");
        Console.WriteLine($"4. {_allReferences[3]}");
        Console.WriteLine("Type 'quit' to exit the program.");
        Console.Write("Please enter your choice (1-4): ");
        string choice = Console.ReadLine();
        
        switch (choice)
        {
            case "1":
                Scripture scripture1 = new Scripture(_allReferences[0], _allScriptures[0]);
                scripture1.Display(); // Display whole scripture
                while (!scripture1.HiddenCompletely()) //loop until all words are hidden
                {
                    Console.WriteLine("\nPress Enter to hide more words, or type 'quit' to exit.");
                    string input = Console.ReadLine();
                    string inputL = input.ToLower();
                    if (inputL == "quit")
                    {
                        Environment.Exit(0); //End Program with 'quit'
                    }
                    scripture1.HideWords();
                    scripture1.Display(); // Display scripture without missing words
                }
                if (scripture1.HiddenCompletely() == true)
                {
                    Environment.Exit(0); //End program when all words are hidden
                }
                break;

            case "2":
                Scripture scripture2 = new Scripture(_allReferences[1], _allScriptures[1]);
                scripture2.Display();
                while (!scripture2.HiddenCompletely())
                {
                    Console.WriteLine("\nPress Enter to hide more words, or type 'quit' to exit.");
                    string input = Console.ReadLine();
                    string inputL = input.ToLower();
                    if (inputL == "quit")
                    {
                        Environment.Exit(0);
                    }
                    scripture2.HideWords();
                    scripture2.Display();
                }
                if (scripture2.HiddenCompletely() == true)
                {
                    Environment.Exit(0);
                }

                break;

            case "3":
                Scripture scripture3 = new Scripture(_allReferences[2], _allScriptures[2]);
                scripture3.Display();
                while (!scripture3.HiddenCompletely())
                {
                    Console.WriteLine("\nPress Enter to hide more words, or type 'quit' to exit.");
                    string input = Console.ReadLine();
                    string inputL = input.ToLower();
                    if (inputL == "quit")
                    {
                        Environment.Exit(0);
                    }
                    scripture3.HideWords();
                    scripture3.Display();
                }
                if (scripture3.HiddenCompletely() == true)
                {
                    Environment.Exit(0);
                }

                break;

            case "4":
                Scripture scripture4 = new Scripture(_allReferences[3], _allScriptures[3]);
                scripture4.Display();
                while (!scripture4.HiddenCompletely())
                {
                    Console.WriteLine("\nPress Enter to hide more words, or type 'quit' to exit.");
                    string input = Console.ReadLine();
                    string inputL = input.ToLower();
                    if (inputL == "quit")
                    {
                        Environment.Exit(0);
                    }
                    scripture4.HideWords();
                    scripture4.Display();
                }
                if (scripture4.HiddenCompletely() == true)
                {
                    Environment.Exit(0);
                }
                break;

            case "quit":
                Environment.Exit(0);
                break;

            default:
                Console.WriteLine("Invalid choice. Please try again.");
                UserChoice();
                break;
        }
    }




}