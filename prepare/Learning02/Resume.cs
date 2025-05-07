public class Resume {
    public string _name;
    public List<Job> _jobs;

    public void Display() {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs: (displayed below) ");
        foreach (Job job in _jobs) {
            job.Display();
        }

    }

}
