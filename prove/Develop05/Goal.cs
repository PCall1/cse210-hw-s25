public abstract class Goal
{
    protected int _rewardValue;
    protected string _name;
    protected string _description;


    protected Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _rewardValue = points;
    }


    public abstract int RecordEvent();
    public abstract void Display();
    public abstract bool IsComplete();


    public virtual List<string> SaveInfo()
    {
        string rewardValue = _rewardValue.ToString();
        return [_name, _description, rewardValue];
    }


}