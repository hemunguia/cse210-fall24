public class ListingActivity : Activity
{
    private List<string> prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private List<string> responses = new List<string>();

    public ListingActivity() : base("Listing Activity", "This activity encourages you to list things you are grateful for.")
    {
    }

    public override void PerformActivity()
    {
        StartActivity();
        Random random = new Random();
        Console.WriteLine(prompts[random.Next(prompts.Count)]);  

        PauseWithAnimation(3);  
        Console.WriteLine("Start listing items:");

        int timeElapsed = 0;
        while (timeElapsed < Duration)
        {
            Console.Write("Item: ");
            responses.Add(Console.ReadLine());
            timeElapsed += 2;  
        }

        Console.WriteLine($"You listed {responses.Count} items.");
        EndActivity();
    }
}
