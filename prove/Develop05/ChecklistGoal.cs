public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus, int amountCompleted = 0) : base(name, description, points)
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
    }
    public override void RecordEvent()
    {
        _amountCompleted += 1;
    }

    public override int GetPoints()
    {
        if (IsComplete() == true)
        {
            return _points + _bonus;
        }

        else
        {
            return _points;
        }

    }
    public override bool IsComplete()
    {
        if (_amountCompleted >= _target)
        {
            return true;
        }

        else
        {
            return false;
        }
    }
    public override string GetDetailsString()
    {
        if (IsComplete() == false)
        {
            return $"[ ] {_shortName} ({_description}) -- Currently completed: {_amountCompleted} / {_target}";
        }

        else
        { 
            return $"[X] {_shortName} ({_description}) -- Currently completed: {_amountCompleted} / {_target}";
        }
    }   

    public override string GetStringRepresentation()
    {
        return $"{nameof (ChecklistGoal)}|{_shortName}|{_description}|{_points}|{_bonus}|{_amountCompleted}|{_target}";
    } 
}