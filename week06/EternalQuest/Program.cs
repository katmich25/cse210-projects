using System;

// Creativity: Added a leveling system that rewards players with new titles as they accumulate points.
// Players progress from Beginner to Adventurer to Master.

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}