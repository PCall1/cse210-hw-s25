using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Google";
        job1._startYear = 1996;
        job1._endYear = 2015;

        Job job2 = new Job();
        job2._jobTitle = "Software Engineer";
        job2._company = "Microsoft";
        job2._startYear = 2015;
        job2._endYear = 2024;


        // create resume and list to add jobs to
        Resume resume = new Resume();
        resume._name = "John Doe";
        resume._jobs = new List<Job>(); // I see this could have been in Resume.cs, to initialize there instead
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);
        resume.Display();
    }

}

