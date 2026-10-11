using System.Security.Cryptography.X509Certificates;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        
        bool running = true;

        while (running)
        {
            DisplayPlayerInfo();
            DisplayLevel();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoalDetails();
                    break;
                case "3":
                    SaveGoals();
                    break;
                case "4":
                    LoadGoals();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points");
    }

    public void ListGoalNames()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetShortName());
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.Write($"{i + 1}. ");
            Console.WriteLine(_goals[i].GetDetailsString());
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
            {
                Console.WriteLine("What is the name of your goal? ");
                string name = Console.ReadLine();

                Console.WriteLine("What is a short description of it? ");
                string description = Console.ReadLine();

                Console.WriteLine("What is the amount of points associated with this goal? ");
                int points = int.Parse(Console.ReadLine());

                SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                _goals.Add(simpleGoal);
                break;
            }

            case "2":
            {
                Console.WriteLine("What is the name of your goal? ");
                string name = Console.ReadLine();

                Console.WriteLine("What is a short description of it? ");
                string description = Console.ReadLine();

                Console.WriteLine("What is the amount of points associated with this goal? ");
                int points = int.Parse(Console.ReadLine());

                EternalGoal eternalGoal = new EternalGoal(name, description, points);
                _goals.Add(eternalGoal);
                break;
            }

            case "3":
                {
                    Console.WriteLine("What is the name of your goal? ");
                    string name = Console.ReadLine();

                    Console.WriteLine("What is a short description of it? ");
                    string description = Console.ReadLine();

                    Console.WriteLine("What is the amount of points associated with this goal? ");
                    int points = int.Parse(Console.ReadLine());

                    Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
                    int target = int.Parse(Console.ReadLine());

                    Console.WriteLine("What is the bonus for accomplishing it that many times? ");
                    int bonus = int.Parse(Console.ReadLine());

                    ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
                    _goals.Add(checklistGoal);

                    break;
                }

            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine($"The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetShortName()}");
        }
        Console.WriteLine("Which goal did you accomplish? ");
        int record = int.Parse(Console.ReadLine());

        Goal goal = _goals[record -1];
        if (!goal.IsComplete())
        {
            goal.RecordEvent();
            _score += goal.GetPoints();

            if (goal is ChecklistGoal)
            {
                if (goal.IsComplete())
                {
                    _score += ((ChecklistGoal)goal).GetBonus();
                }
            }
        }
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    
    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(filename);

        _score = int.Parse(lines[0]);
        _goals.Clear();

        foreach (string line in lines.Skip(1))
        {
            string[] parts = line.Split(',');

            if (parts[0] == "SimpleGoal")
            {
                SimpleGoal goal = new SimpleGoal(
                    parts[1], parts[2], int.Parse(parts[3]));

                goal.SetComplete(bool.Parse(parts[4]));
                _goals.Add(goal);
            }
            else if (parts[0] == "EternalGoal")
            {
                EternalGoal goal = new EternalGoal(
                    parts[1], parts[2], int.Parse(parts[3]));

                _goals.Add(goal);
            }
            else if (parts[0] == "ChecklistGoal")
            {
                ChecklistGoal goal = new ChecklistGoal(
                    parts[1], parts[2], int.Parse(parts[3]),
                    int.Parse(parts[5]), int.Parse(parts[6]));

                goal.SetAmountCompleted(int.Parse(parts[4]));
                _goals.Add(goal);
            }
        }
    }
    public void DisplayLevel()
    {
        if (_score < 1000)
        {
            Console.WriteLine("Level 1: Beginner");
        }
        else if (_score < 2500)
        {
            Console.WriteLine("Level 2: Adventurer");
        }
        else
        {
            Console.WriteLine("Level 3: Master");
        }
    }

}