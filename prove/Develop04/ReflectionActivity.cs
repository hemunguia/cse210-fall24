public class ReflectionActivity : Activity
{
    private List<string> prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity() : base("Reflection Activity", "This activity helps you reflect on times of strength and resilience.")
    {
    }

   public override void PerformActivity()
    {
        StartActivity();
        Random random = new Random();
        Console.WriteLine(prompts[random.Next(prompts.Count)]);  

        int timeElapsed = 0;
        List<string> unusedQuestions = new List<string>(questions);  

        while (timeElapsed < Duration && unusedQuestions.Count > 0)
        {
            int index = random.Next(unusedQuestions.Count);  
            Console.WriteLine(unusedQuestions[index]);
            PauseWithAnimation(3);

            unusedQuestions.RemoveAt(index);  
            timeElapsed += 3;
        }

        EndActivity();
    }
}
