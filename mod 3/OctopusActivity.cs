using System;

enum Activity
{
    Resting,
    Swimming,
    Eating,
    Hiding
}

class Octopus
{
    public readonly string Name;
    public readonly int Legs = 8;
    public Activity CurrentActivity;

    public Octopus(string name, Activity activity)
    {
        Name = name;
        CurrentActivity = activity;
    }
}

class Program
{
    static void Main()
    {
        Octopus octopus1 = new Octopus("Oscar", Activity.Swimming);
        Octopus octopus2 = new Octopus("Hank", Activity.Hiding);

        Console.WriteLine("Octopus 1");
        Console.WriteLine("Name: " + octopus1.Name);
        Console.WriteLine("Legs: " + octopus1.Legs);
        Console.WriteLine("Activity: " + octopus1.CurrentActivity);

        Console.WriteLine();

        Console.WriteLine("Octopus 2");
        Console.WriteLine("Name: " + octopus2.Name);
        Console.WriteLine("Legs: " + octopus2.Legs);
        Console.WriteLine("Activity: " + octopus2.CurrentActivity);
    }
}