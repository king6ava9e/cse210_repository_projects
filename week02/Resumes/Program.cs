using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");
      Job job1 = new Job();     
        job1._jobTitle = "Software Engineer";
        job1._startYear = "2020";
        job1._endYear = "2022";
        job1._company = "Microsoft";
        Job job2 = new Job();
        job2._jobTitle = "DevOps Engineer";
        job2._startYear = "2022";
        job2._endYear = "2023";
        job2._company = "Google";
       
       var resume = new Resume();
        resume._name = "Acheampong Kingsley";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);
       
       

        
        resume.Display();

      
    }
}