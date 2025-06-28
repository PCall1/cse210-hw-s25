public class Simple : Goal
{
    private bool _isComplete;

    public Simple(string name, string description, int rewardValue)
    : base(name, description, rewardValue) => _isComplete = false;
    public Simple(string name, string description, int rewardValue, bool isComplete)
    : base(name, description, rewardValue) => _isComplete = isComplete;


    public override int RecordEvent()
    {
        _isComplete = true;
        return _rewardValue;
    }

    public override void Display()
    {
        if (_isComplete)
        {
            Console.WriteLine($"[X] {_name} ({_description})");
        }
        else
        {
            Console.WriteLine($"[ ] {_name} ({_description})");
        }
    }

    public override bool IsComplete() => _isComplete;
    public override List<string> SaveInfo() => ["Simple Goal", ..base.SaveInfo(), _isComplete.ToString()]; 
}