using System;
public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();

    public void DisplayResume()
    {
        Console.Write($"Name: {_name}\nJobs:\n");
        foreach (Job job in _jobs)
        {
            job.DisplayJobDetails();
        }
    }
}