using System.Text.Json;

class JournalManager
{
    public void SaveJournal(List<string> journalEntries)
    {
        Console.Write("Enter the filename to save");
        string filename = Console.ReadLine();
            File.WriteAllLines(filename, journalEntries);
            Console.WriteLine($"Journal saved to {filename}");
    }
   
    public List<string> LoadJournal()
    {
        Console.WriteLine("Enter the filename to load");
        string filename = Console.ReadLine();
       
            if (File.Exists(filename))
            {
                var entries = new List<string>(File.ReadAllLines(filename));
                Console.WriteLine($"Journal loaded from {filename}");
                return entries;
            }
            else
            {
                Console.WriteLine("File not found.");
            }
       
        return new List<string>(); 
    }

    public void DisplayJournal(List<string> journalEntries)
    {
        if (journalEntries.Count == 0)
        {
            Console.WriteLine("The journal is empty.");
        }
        else
        {
            Console.WriteLine("Your Journal Entries:");
            foreach (string entry in journalEntries)
            {
                Console.WriteLine($"{entry}");
            }
        }
    }

      public void SaveJournalAsJson(List<string> journalEntries)
    {
        Console.Write("Enter the filename to save the journal as filename.json:");
        string filename = Console.ReadLine();
         
            string json = JsonSerializer.Serialize(journalEntries, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filename, json);
            Console.WriteLine($"Journal saved as JSON to {filename}");
        
    }

    public List<string> LoadJournalFromJson()
    {
        Console.WriteLine("Enter the filename to load the journal from JSON (e.g., journal.json):");
        string filename = Console.ReadLine();
      
            if (File.Exists(filename))
            {
                string json = File.ReadAllText(filename);
                var entries = JsonSerializer.Deserialize<List<string>>(json);
                Console.WriteLine($"Journal loaded from {filename}");
                return entries;
            }
            else
            {
                Console.WriteLine("File not found.");
            }
       
        return new List<string>(); // Return an empty list if something goes wrong
    }
}