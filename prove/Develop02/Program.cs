using System;

class Program
{
   // List to store journal entries in memory
    static List<string> journalEntries = new List<string>();
    static JournalManager journalManager = new JournalManager();
    static JournalEntry journalEntry = new JournalEntry();

    static void Main(string[] args)
    {
        int number;

        do
        {
            Console.WriteLine("Welcome to the Journal Entry App");
            Console.WriteLine("1. Write a New Entry");
            Console.WriteLine("2. Display the Journal");
            Console.WriteLine("3. Save the Journal as txt");
            Console.WriteLine("4. Load the txt Journal");
            Console.WriteLine("5. Save Journal as JSON");
            Console.WriteLine("6. Load the JSON Journal");
            Console.WriteLine("7. Exit the App");

            // Read and parse the user's response
            string response = Console.ReadLine();
            if (!int.TryParse(response, out number))
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 7.");
                continue;
            }

            // Using if-else instead of switch
            if (number == 1)
            {
                string newEntry = journalEntry.WriteEntry();
                journalEntries.Add(newEntry);
            }
            else if (number == 2)
            {
                journalManager.DisplayJournal(journalEntries);
            }
            else if (number == 3)
            {
                journalManager.SaveJournal(journalEntries);
            }
            else if (number == 4)
            {
                journalEntries = journalManager.LoadJournal();
            }
            else if (number == 5)
            {
                journalManager.SaveJournalAsJson(journalEntries);
            }
              else if (number == 6)
            {
              journalEntries = journalManager.LoadJournalFromJson();      
            }
              else if (number == 7)
            {
                Console.WriteLine("Exiting the Journal...");       
            }
            else
            {
                Console.WriteLine("Please choose a valid option (1-7).");
            }

        } while (number != 7);
    }


}