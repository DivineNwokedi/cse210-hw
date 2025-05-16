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
                    Entry entry = new Entry(prompt, DateTime.Now.ToString("yyyy-MM-dd"), entryText);
                    journal.AddEntry(entry);
                    break;
                case "2":
                    journal.DisplayEntries();
                    break;
                case "3":
                    Console.Write("Enter filename to save to: ");
                    string saveFilename = Console.ReadLine();
                    journal.WriteToFile(saveFilename);
                    break;
                case "4":
                    Console.Write("Enter filename to load from: ");
                    string loadFilename = Console.ReadLine();
                    journal.ReadFromFile(loadFilename);
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid option. Please choose again.");
                    break;
            }
        }
    }
}

