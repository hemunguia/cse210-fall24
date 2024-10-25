using System;

class Program
{
    static void Main(string[] args)
    {
        //Reference scriptureReference = new Reference("Proverbs", 3, 5, 6);
        Reference scriptureReference = new Reference("John", 3, 16);
        //string scriptureText = "Trust in the Lord with all your heart and lean not on your own understanding.";
        string scriptureText = "For God so loved the world, that he gave his only begotten Son, " +
                       "that whosoever believeth in him should not perish, but have everlasting life.";

        Scripture scripture = new Scripture(scriptureReference, scriptureText);

        while (true)
        {
            Console.Clear();

            scripture.Display();

            if (scripture.IsAllWordsHidden())
            {
                Console.WriteLine("All words are hidden. Program will now exit.");
                break;
            }

            Console.WriteLine("\nPress Enter to hide some words, or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                Console.WriteLine("Program will now exit.");
                break;
            }

            scripture.HideRandomWords();
       }
    }
}