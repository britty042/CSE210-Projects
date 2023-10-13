using System.Runtime.CompilerServices;

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }
    public abstract void RecordEvent();
    
    public abstract bool IsComplete();
   
    public virtual string GetDetailsString()
    {
        if (IsComplete() == false)
        {
            return $"[ ] {_shortName} ({_description})";
        }

        else
        { 
            return $"[X] {_shortName} ({_description})";
        }
    }   

    public string GetName()
    {
        return _shortName;
    }

    public virtual int GetPoints()
    {
        return _points;
    }
    public abstract string GetStringRepresentation();
}