// To exceed requirements, I created a new option for the user to edit an entry.
using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new();
        Entry entry = new();
        PromptGenerator promptGenerator = new();

        bool repeat = true;

        Console.WriteLine("My Journal Program menu");
        while (repeat) {
            Console.WriteLine("Journal Program Menu:");
            Console.WriteLine("\n1. Write a new entry");
            Console.WriteLine("\n2. Display the journal");
            Console.WriteLine("\n3. Save the journal to a file");
            Console.WriteLine("\n4. Load the journal from a file");
            Console.WriteLine("\n5. Edit Entries"); // Creativity 
            Console.WriteLine("\n6. Exit");
            Console.Write(" Please enter your choice: ");
            int selectedNum = int.Parse(Console.ReadLine());


            if (selectedNum == 1) {
                string randomPrompt = promptGenerator.GenerateRandomPrompt();
                Console.WriteLine(randomPrompt);

                journal.Entries.Add(entry.GenerateNewEntry(randomPrompt));
              }
              else if (selectedNum == 2) {
                journal.DisplayEntries();
              }
              else if (selectedNum == 3) {
                journal.LoadFromFile();
              }
              else if (selectedNum == 4) {
                journal.SaveToFile();
              }
              else if (selectedNum == 5) { //Creativity line
                journal.DisplayEntries(true);
                journal.EditEntry();
              }
              else if (selectedNum == 6) {
                repeat = false;
              }
        }
    }
}
