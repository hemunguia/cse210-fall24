using System;
using System.Collections.Generic;
using System.Threading;

public abstract class Activity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Duration { get; set; }

    public Activity(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public void StartActivity()
    {
        Console.WriteLine($"Starting: {Name}");
        Console.WriteLine(Description);
        Console.Write("Enter the duration in seconds: ");
        Duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        PauseWithAnimation(3); 
    }

    public void EndActivity()
    {
        Console.WriteLine("Good job! You've completed the activity.");
        Console.WriteLine($"You completed: {Name} for {Duration} seconds.");
        PauseWithAnimation(3);
    }

protected void PauseWithAnimation(int seconds)
{
    char[] animationChars = { '+', '-', '/' };
    int totalTime = seconds * 1000;
    int animationSpeed = 150;  
    int cycles = totalTime / animationSpeed;

    for (int i = 0; i < cycles; i++)
    {
        Console.Write(animationChars[i % animationChars.Length]);  
        Thread.Sleep(animationSpeed);  
        Console.Write("\b \b");  
    }
    Console.WriteLine();
}
    public abstract void PerformActivity();
}
