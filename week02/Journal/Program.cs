// I added a feature to save the user's mood with each journal entry.
// This allows users to track their emotions over time and reflect on how their mood has changed.


using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        RandomPromptGenerator promptGenerator = new RandomPromptGenerator();

        while (true)
        {
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Quit");

            Console.Write("Choose an option: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    string prompt = promptGenerator.GetPrompt();
                    Console.WriteLine(prompt);
                    Console.Write("Enter your journal entry: ");
                    string entryText = Console.ReadLine();
                    Console.Write("How are you feeling today? (e.g. happy, sad, neutral): ");
                    string mood = Console.ReadLine();
                    Entry entry = new Entry(prompt, DateTime.Now.ToString("yyyy-MM-dd"), entryText, mood);
                    journal.AddEntry(entry);
                    break;
                // ...
            }
        }
    }
}
