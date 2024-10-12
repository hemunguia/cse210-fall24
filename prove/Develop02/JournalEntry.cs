class JournalEntry
{
    private List<string> questions = new List<string>
    {
        "What did you do today?",
        "Did you talk to a relative?",
        "How was work today?",
        "Did you read something new today?",
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    public string WriteEntry()
    {
        Random random = new Random();
        int index = random.Next(questions.Count);

        Console.Write(questions[index]);
        string entry = Console.ReadLine();
        string dateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

        return $"{dateTime} - {questions[index]} {entry}";
    }
}
