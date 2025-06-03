class WritingAssignment : Assignment
{
    private string _essayTitle;

    public WritingAssignment(string studentName, string topic, string essayTitle)
        : base(studentName, topic)
    {
        _essayTitle = essayTitle;
    }

    public string GetWritingInfo()
    {
        return $"{_essayTitle} - by {GetStudentName()}\n";
    }
}