using System;
using System.Collections.Generic;

public class RandomPromptGenerator
{
    private List<string> _prompts;
    private Random _random;

    public RandomPromptGenerator()
    {
        _prompts = new List<string>()
        {
            "What did you learn today?",
            "What are you grateful for?",
            "What challenges did you face?"
        };
        _random = new Random();
    }

    public string GetPrompt()
    {
        return _prompts[_random.Next(_prompts.Count)];
    }
}


