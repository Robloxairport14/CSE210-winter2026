class Eternal : Goal
{
    // private
    public void Lanrete()
    {
        Console.WriteLine("What's the name of the goal?");
        string name_e = Console.ReadLine();
        Console.WriteLine("What's a short description of it?");
        string description_e = Console.ReadLine();
        Console.WriteLine("What is the amount of points associated with this goal?");
        int points_e = Convert.ToInt32(Console.ReadLine());
        return;
    }
}