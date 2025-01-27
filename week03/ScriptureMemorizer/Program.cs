using System;
using System.Collections.Generic;

// For the extra creativity, I've added an exceeded requirement feature, a method named SaveProgress that saves 

// the current scripture's state to a file. This allows users to save their progress for later review.
class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptureLibrary = new List<Scripture>
        {
            new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."),
            new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight."),
        };

        Random random = new Random();
        Scripture selectedScripture = scriptureLibrary[random.Next(scriptureLibrary.Count)];

        Console.WriteLine("You are welcome to My Scripture Memorizer Program!");
        Console.WriteLine("Press Enter to hide words, or type 'Quit' to exit.");

        while (true)
        {
            Console.Clear();
            Console.WriteLine(selectedScripture);

            if (selectedScripture.AllWordsHidden())
            {
                Console.WriteLine("Nicely Done! You've successfully hidden the entire scripture.");
            }

            Console.WriteLine("\nPress Enter to hide words or type 'Quit' to exit.");
            string userInput = Console.ReadLine();

            if (userInput == "quit")
            {
                Console.WriteLine("Thank you for using my Scripture Memorizer Program, See you next time. Goodbye!");
            }

            selectedScripture.HideWords(4);
        }
    }

    // Creativity Line: Save progress to a file
    public static void SaveProgress(Scripture scripture, string filePath)
    {
        System.IO.File.WriteAllText(filePath, scripture.ToString());
        Console.WriteLine($"Progress saved to {filePath}");
    }
}
