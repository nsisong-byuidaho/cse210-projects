using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        
        var activities = new List<Activity>
        {
            new Running(new DateTime(2022, 11, 3), 30, 3.0), 
            new Cycling(new DateTime(2022, 11, 4), 45, 12.0), 
            new Swimming(new DateTime(2022, 11, 5), 40, 20) 
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
