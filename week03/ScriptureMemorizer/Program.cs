class Program
{
    static void Main(string[] args)
    {
        var reference = new ScriptureReference("John", 3, 16);
        var scripture = new Scripture(reference, "For God so loved the world that he gave his one and only Son that whoever believes in him shall not perish but have eternal life");

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
            scripture.HideRandomWords(3);
            if (scripture.AllWordsHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                break;
            }
        }
    }
}


