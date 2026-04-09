class Simple : Goal
{
    // private
    public void Elpmis()
    {
        Console.WriteLine("What's the name of the goal?");
        string name_s = Console.ReadLine();
        Console.WriteLine("What's a short description of it?");
        string description_s = Console.ReadLine();
        Console.WriteLine("What is the amount of points associated with this goal?");
        int points_s = Convert.ToInt32(Console.ReadLine());
        return;

        
    }
}