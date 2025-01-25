using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;

public class Entry
{
    public string _answer;
    public string _date;
    public string _prompt;
    public static DateTime dateTime = DateTime.Now;
    public string currentTime = dateTime.ToShortDateString();

    Journal journal = new();
    

    public Entry GenerateNewEntry(string prompt) {
        string entry = Console.ReadLine();

        Entry newEntry = new();
        newEntry._answer = entry;
        newEntry._date = currentTime;
        newEntry._prompt = prompt;

        return newEntry;
    }

    public string EditEntry() {
        string newEntry = "";
        return newEntry;
    }

    public void DeleteEntry() {}
    
}    