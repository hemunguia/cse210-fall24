public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;

    public ChecklistGoal(string name, int points, int targetCount, int bonusPoints) : base(name, points)
    {
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
        _currentCount = 0;
    }

    public override int RecordEvent()
    {
        if (_currentCount < _targetCount)
        {
            _currentCount++;
            if (_currentCount == _targetCount)
            {
                IsComplete = true;
                return Points + _bonusPoints; 
            }
            return Points;
        }
        return 0;
    }

    public override string GetProgress() => IsComplete ? "[X]" : $"Completed {_currentCount}/{_targetCount} times";
}
