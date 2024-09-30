using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
        Job job = new Job();
        Job job1 = new Job();
        Resume resume = new Resume();

        job._company="Microsoft";
        job._jobTitle="Software Engineer";
        job._startYear=2019;
        job._endYear=2022;

        job1._company="Apple";
        job1._jobTitle="Manager";
        job1._startYear=2022;
        job1._endYear=2023;

        resume._name ="Herbert";
        resume._jobs.Add(job);
        resume._jobs.Add(job1);


        resume.Display();




   
    }
}