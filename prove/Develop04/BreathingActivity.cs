public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by guiding you through breathing exercises.")
    {
    }

    public override void PerformActivity()
    {
        StartActivity();
        int timeElapsed = 0;
        while (timeElapsed < Duration)
        {
            Console.WriteLine("Breathe in...");
            PauseWithAnimation(3);
            Console.WriteLine("Breathe out...");
            PauseWithAnimation(3);
            timeElapsed += 6;  
        }
        EndActivity();
    }
}
