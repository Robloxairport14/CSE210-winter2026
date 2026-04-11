class Eternal : Goal
{
    // private
    public void Lanrete()
    {
        Console.WriteLine("What's the name of the goal?");
        _name = Console.ReadLine();
        Console.WriteLine("What's a short description of it?");
        _description = Console.ReadLine();
        Console.WriteLine("What is the amount of points associated with this goal?");
        _points = Convert.ToInt32(Console.ReadLine());
        _type = "Eternal";
        return;
    }
}