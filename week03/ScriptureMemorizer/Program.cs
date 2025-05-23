class Program
{
    static void Main(string[] args)
    {
        // Exceeding core requirements: Added a menu system to select different scriptures and difficulty levels
        Console.WriteLine("Select a scripture:");
        Console.WriteLine("1. John 3:16");
        Console.WriteLine("2. Philippians 4:13");
        var scriptureChoice = Console.ReadLine();

        ScriptureReference reference;
        string text;

        switch (scriptureChoice)
        {
            case "1":
                reference = new ScriptureReference("John", 3, 16);
                text = "For God so loved the world that he gave his one and only Son that whoever believes in him shall not perish but have eternal life";
                break;
            case "2":
                reference = new ScriptureReference("Philippians", 4, 13);
                text = "I can do all this through him who gives me strength";
                break;
            default:
                Console.WriteLine("Invalid choice. Exiting...");
                return;
        }

        var scripture = new Scripture(reference, text);

        Console.WriteLine("Select a difficulty level:");
        Console.WriteLine("1. Easy (hide 1 word at a time)");
        Console.WriteLine("2. Medium (hide 2 words at a time)");
        Console.WriteLine("3. Hard (hide 3 words at a time)");
        var difficultyChoice = Console.ReadLine();

        int wordsToHide;

        switch (difficultyChoice)
        {
            case "1":
                wordsToHide = 1;
                break;
            case "2":
                wordsToHide = 2;
                break;
            case "3":
                wordsToHide = 3;
                break;
            default:
                Console.WriteLine("Invalid choice. Exiting...");
                return;
        }
        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("Press enter to hide words, or type 'quit' to exit.");
            var input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }
            scripture.HideRandomWords(wordsToHide);
            if (scripture.AllWordsHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("Congratulations! You have memorized the scripture.");
                break;
            }
        }
    }
}


