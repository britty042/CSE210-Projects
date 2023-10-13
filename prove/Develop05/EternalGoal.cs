public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {

    }
    public override void RecordEvent()
    {
        //This goal can never be complete, therefore this class does nothing.
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"{nameof (EternalGoal)}|{_shortName}|{_description}|{_points}";
    } 
}