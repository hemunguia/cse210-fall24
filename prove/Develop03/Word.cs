public class Word
{
    private string text;
    private bool isHidden;
    public Word(string wordText)
    {
        text = wordText;
        isHidden = false; 
    }
    public void Hide()
    {
        isHidden = true;
    }
    public void Show()
    {
        isHidden = false;
    }
    public bool IsHidden()
    {
        return isHidden;
    }
    public override string ToString()
    {
        return isHidden ? "____" : text;
    }
}
