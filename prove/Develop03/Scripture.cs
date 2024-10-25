public class Scripture
{
    private Reference reference;
    private List<Word> text;
    public Scripture(Reference reference, string scriptureText)
    {
        this.reference = reference;
        this.text = scriptureText.Split(' ')
                                 .Select(word => new Word(word))
                                 .ToList();
    }
    public void Display()
    {
        Console.WriteLine(reference.ToString());
        foreach (Word word in text)
        {
            Console.Write(word.ToString() + " ");
        }
        Console.WriteLine();
    }
    public void HideRandomWords()
    {
        Random rand = new Random();
         List<Word> visibleWords = text.Where(word => !word.IsHidden()).ToList();
        if (visibleWords.Count > 0)
        {
            int randomIndex = rand.Next(visibleWords.Count);
            visibleWords[randomIndex].Hide();
        }
    }
    public bool IsAllWordsHidden()
    {
        return text.All(word => word.IsHidden());
    }
}
