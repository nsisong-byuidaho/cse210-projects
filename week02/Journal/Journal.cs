using System.ComponentModel.DataAnnotations;
using System.IO;
public class Journal
{
    public List<Entry> Entries = new();
    public string _fileName;

    public void DisplayEntries(bool edit = false) {
        if (edit == true)
        {
            int index = 1;
            foreach (Entry e in Entries)
            {
            Console.WriteLine($"{index}. {e._date} - {e._prompt}\n{e._answer}\n");
            index++;
            }
        }
        else
        {
            foreach (Entry e in Entries)
            {
            Console.WriteLine($"{e._date} - {e._prompt}\n{e._answer}\n");
            }
        }
        
    }

    public void EditEntry() {
        Console.Write("Which entry would you want to update? (0 to return) ");
        int entryIndex = int.Parse(Console.ReadLine()) -1;

        if (entryIndex >= 0)
        {
        Console.WriteLine($"\n{Entries[entryIndex]._date} - {Entries[entryIndex]._prompt}");
        string newAnswer = Console.ReadLine();

        Entries[entryIndex]._answer = newAnswer;
        }
        else if (entryIndex == 0) {}
        else {}
    }

    public void LoadFromFile() {
        Console.Write("Please enter filename to load the journal: ");
        string fileName = Console.ReadLine();

        Console.WriteLine("Reading journal from file...");
        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            string[] parts = line.Split("||");

            Entry newEntry = new();
            newEntry._answer = parts[2];
            newEntry._date = parts[0];
            newEntry._prompt = parts[1];

            Entries.Add(newEntry);
        }
    }

    public void SaveToFile() {
        Console.Write("Please enter filename to save the journal: ");
        string fileName = Console.ReadLine();

        Console.WriteLine("Saving journal to file...");
        using(StreamWriter outputfile = File.AppendText(fileName))
        {
            foreach (Entry e in Entries)
            {
                outputfile.WriteLine($"{e._date}||{e._prompt}||{e._answer}");
            }
        }

    }
}