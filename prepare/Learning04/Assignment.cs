using System.Reflection;
using System.Runtime.InteropServices;

class Assignment
{
    private string _studentName;
    private string _topic;

    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    public string GetSummary()
    {
        return $"Name: {_studentName}\n" +
        $"Topic: {_topic}";
    }

    public string GetStudentName()
    {
        return _studentName;
    }

}