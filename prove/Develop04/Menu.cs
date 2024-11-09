public class Menu
{
    private List<Activity> activities = new List<Activity>();

    public Menu()
    {
        activities.Add(new BreathingActivity());
        activities.Add(new ReflectionActivity());
        activities.Add(new ListingActivity());
    }

    public void DisplayMenu()
    {
        while (true)
        {
            Console.WriteLine("Choose an activity:");
            for (int i = 0; i < activities.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {activities[i].Name}");
            }
            Console.WriteLine("0. Exit");

            int choice = int.Parse(Console.ReadLine());
            if (choice == 0) break;
            if (choice > 0 && choice <= activities.Count)
            {
                activities[choice - 1].PerformActivity();
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}
