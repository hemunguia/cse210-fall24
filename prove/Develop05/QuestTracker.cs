public class QuestTracker
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public void AddGoal(Goal goal) => _goals.Add(goal);

    public void ListGoals()
    {
        foreach (var goal in _goals)
            Console.WriteLine($"{goal.GetProgress()} {goal.Name}");
    }

    public void RecordGoalEvent(int index)
    {
        if (index < 0 || index >= _goals.Count) return;

        int pointsEarned = _goals[index].RecordEvent();
        _score += pointsEarned;
        Console.WriteLine($"Recorded! You earned {pointsEarned} points.");
    }

    public void DisplayScore() => Console.WriteLine($"Total Score: {_score}");

    public void SaveProgress(string filename)
    {
        
    }

    public void LoadProgress(string filename)
    {
        
    }
}
