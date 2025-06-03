class MathAssignment : Assignment
{
    private string _selection;
    private string _problemNumbers;

    public MathAssignment(string studentName, string topic, string selection, string problemNumbers)
        : base(studentName, topic)
    {
        _selection = selection;
        _problemNumbers = problemNumbers;
    }

    public string GetHomeworkList()
    {
        return $"{_selection}:  {_problemNumbers}";
    }
}