public class Eternal : Goal
{
    public Eternal(string name, string description, int rewardValue) : base(name, description, rewardValue) {}
    public override int RecordEvent() => _rewardValue;
    public override void Display() => Console.WriteLine($"[ ] {_name} ({_description})");
    public override bool IsComplete() => false;
    public override List<string> SaveInfo() => ["Eternal Goal", .. base.SaveInfo()];
}