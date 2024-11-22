public class Program
{
    static void Main(string[] args)
    {
        QuestTracker tracker = new QuestTracker();
        QuestUI questUI = new QuestUI(tracker);

        while (true)
        {
            Console.WriteLine("\nChoose an action:");
            Console.WriteLine("1. Add Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Goal Event");
            Console.WriteLine("4. Display Score");
            Console.WriteLine("5. Save Progress");
            Console.WriteLine("6. Load Progress");
            Console.WriteLine("7. Exit");

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    questUI.AddGoal();
                    break;
                case 2:
                    tracker.ListGoals();
                    break;
                case 3:
                    questUI.RecordGoal();
                    break;
                case 4:
                    tracker.DisplayScore();
                    break;
                case 5:
                    questUI.SaveProgress();
                    break;
                case 6:
                    questUI.LoadProgress();
                    break;
                case 7:
                    Console.WriteLine("Exiting program. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        }
    }
}
