public class Checklist : Goal
{
    private int _bonusPoints;
    private int _iterations;
    private int _currentProgress;
    private bool _isComplete;


    public Checklist(int bonus, int iterations, string name, string description, int points)
    : base(name, description, points)
    {
        _bonusPoints = bonus;
        _iterations = iterations;
        _currentProgress = 0;
        _isComplete = false;
    }
    public Checklist(int bonus, int iterations, string name, string description, int points,
    bool isComplete, int currentProgress)
    : base(name, description, points)
    {
        _bonusPoints = bonus;
        _iterations = iterations;
        _currentProgress = currentProgress;
        _isComplete = isComplete;

    }


    public override int RecordEvent()
    {
        if (_isComplete == false)
        {
            _currentProgress++;
            if (_currentProgress < _iterations)
                return _rewardValue;
            else
            {
                _isComplete = true;
                return _rewardValue + _bonusPoints;
            }
        }
        else
            return 0;
    }

    public override bool IsComplete()
    {
        if (_currentProgress >= _iterations)
            return true;
        else
            return false;
    }

    public override void Display()
    {
        if (_isComplete)
        {
            Console.WriteLine($"[X] {_name} ({_description}) ({_currentProgress}/{_iterations})");
        }
        else
        {
            Console.WriteLine($"[ ] {_name} ({_description}) ({_currentProgress}/{_iterations})");
        }
    }

        public override List<string> SaveInfo() => ["Checklist Goal", ..base.SaveInfo(), _isComplete.ToString(),
        _currentProgress.ToString(), _iterations.ToString(), _bonusPoints.ToString()]; 

}