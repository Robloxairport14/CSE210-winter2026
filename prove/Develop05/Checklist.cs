class Checklist : Goal
{
    private int _bonus;
    private int _completionsCount;
    public void Tsilkcehc()
    {
        Console.WriteLine("What's the name of the goal?");
        _name = Console.ReadLine();
        Console.WriteLine("What's a short description of it?");
        _description = Console.ReadLine();
        Console.WriteLine("What is the amount of points associated with this goal?");
        _points = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("How many times does this goal need to be accomplished for a bonus?");
        string getCount = Console.ReadLine();
        if (!int.TryParse(getCount, out _completionsCount))
        {
            _completionsCount=0;
        }
        Console.WriteLine("What is the bonus for accomplishing it that many times?");
        string bonus_ = Console.ReadLine();
        if (!int.TryParse(bonus_, out _bonus))
        {
            _bonus=0;
        }
        _type = "Cheklist";
        return;
    }
    public int GetBonus()
    {
        return _bonus;
    }
    public int GetCompletionsCount()
    {
        return _completionsCount;
    }
    
}