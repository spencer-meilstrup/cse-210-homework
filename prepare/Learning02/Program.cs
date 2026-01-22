using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._companyName = "Microsoft";
        job1._startYear = 2005;
        job1._endYear = 2013;
        // job1.ShowJobDetails();
        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._companyName = "Apple";
        job2._startYear = 2013;
        job2._endYear = 2018;
        // job2.ShowJobDetails();
        Resume userResume = new Resume();
        userResume._userName = "Cody Hackins";
        userResume._jobs.Add(job1);
        userResume._jobs.Add(job2);
        userResume.ShowResume();
        // Console.WriteLine($"{userResume._jobs[0]._jobTitle}");
    }
}