class Listing : Activity
{
    private string _letitallout;
    
    public Listing() //constructor
    {
        _name = "list";
        _closingMsg = "Thak you for participating in option 3, listing.";
        _desc = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }
    
    public void Startch() //start
    {
        Console.WriteLine($"{_name}");
        Console.WriteLine($"{_desc}");
        PromptDuration();

        int result = Dice(5);

        if (result == 1)
            Animation("Who are people that you appreciate?", 5);
        else if (result == 2)
            Animation("What are personal strengths of yours?", 5);
        else if (result == 3)
            Animation("Who are people that you have helped this week?", 5);
        else if (result == 4)
            Animation("When have you felt the Holy Ghost this month?", 5);
        else if (result == 5)
            Animation("Who are some of your personal heroes?", 5);
        DateTime startTime = DateTime.Now;
        DateTime finishTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < finishTime)
        {
            Console.Write(":");
            string _letitallout = Console.ReadLine();
        }
        Console.WriteLine($"{_closingMsg}");
    }

        public string Type()
    {
        return _letitallout;
    }
}