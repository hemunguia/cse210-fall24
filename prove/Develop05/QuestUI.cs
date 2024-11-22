public class QuestUI
{
    private QuestTracker _tracker;

    public QuestUI(QuestTracker tracker)
    {
        _tracker = tracker;
    }

    public void AddGoal()
    {
        Console.WriteLine("\nChoose the type of goal to add:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        int goalType;
        if (!int.TryParse(Console.ReadLine(), out goalType) || goalType < 1 || goalType > 3)
        {
            Console.WriteLine("Invalid choice. Returning to main menu.");
            return;
        }

        Console.WriteLine("Enter the goal name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter the points for completing this goal:");
        int points;
        if (!int.TryParse(Console.ReadLine(), out points))
        {
            Console.WriteLine("Invalid points. Returning to main menu.");
            return;
        }

        switch (goalType)
        {
            case 1:
                _tracker.AddGoal(new SimpleGoal(name, points));
                Console.WriteLine("Simple Goal added successfully!");
                break;
            case 2:
                _tracker.AddGoal(new EternalGoal(name, points));
                Console.WriteLine("Eternal Goal added successfully!");
                break;
            case 3:
                Console.WriteLine("Enter the number of times to complete the goal:");
                int targetCount;
                if (!int.TryParse(Console.ReadLine(), out targetCount))
                {
                    Console.WriteLine("Invalid count. Returning to main menu.");
                    return;
                }

                Console.WriteLine("Enter the bonus points for completing this goal:");
                int bonusPoints;
                if (!int.TryParse(Console.ReadLine(), out bonusPoints))
                {
                    Console.WriteLine("Invalid bonus points. Returning to main menu.");
                    return;
                }

                _tracker.AddGoal(new ChecklistGoal(name, points, targetCount, bonusPoints));
                Console.WriteLine("Checklist Goal added successfully!");
                break;
        }
    }

    public void RecordGoal()
    {
        _tracker.ListGoals();
        Console.WriteLine("Enter the index of the goal to record progress:");

        int index;
        if (!int.TryParse(Console.ReadLine(), out index))
        {
            Console.WriteLine("Invalid input. Returning to main menu.");
            return;
        }

        _tracker.RecordGoalEvent(index);
    }

    public void SaveProgress()
    {
        Console.WriteLine("Enter the filename to save progress (e.g., progress.json):");
        string filename = Console.ReadLine();

        try
        {
            _tracker.SaveProgress(filename);
            Console.WriteLine($"Progress saved to {filename} successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving progress: {ex.Message}");
        }
    }

    public void LoadProgress()
    {
        Console.WriteLine("Enter the filename to load progress (e.g., progress.json):");
        string filename = Console.ReadLine();

        try
        {
            _tracker.LoadProgress(filename);
            Console.WriteLine($"Progress loaded from {filename} successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading progress: {ex.Message}");
        }
    }
}
