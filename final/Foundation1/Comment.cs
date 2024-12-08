namespace YouTubeVideoTracking
{
    public class Comment
    {
        // Properties
        public string CommenterName { get; private set; }
        public string Text { get; private set; }

        // Constructor
        public Comment(string commenterName, string text)
        {
            CommenterName = commenterName;
            Text = text;
        }
    }
}
