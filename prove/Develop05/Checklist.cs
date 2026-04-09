class Checklist : Goal
{
    private int _bonus;
    private int _completionsCount;
    public void Tsilkcehc()
    {
        Console.WriteLine("What's the name of the goal?");
        string name_c = Console.ReadLine();
        Console.WriteLine("What's a short description of it?");
        string description_c = Console.ReadLine();
        Console.WriteLine("What is the amount of points associated with this goal?");
        int points_c = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("How many times does this goal need to be accomplished for a bonus?");
        string GetCount = Console.ReadLine();
        if (!int.TryParse(GetCount, out _completionsCount))
        Console.WriteLine("What is the bonus for accomplishing it that many times?");
        string bonus_ = Console.ReadLine();
        if (!int.TryParse(bonus_, out _bonus))
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