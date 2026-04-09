class Goal
{
    protected string _description;
    protected string _name;
    protected int _points;
    protected bool _isComplete;
    // public void PromptDuration()
    // {
        
    // }
    public void Start()
    {
        Console.WriteLine("The Type of Goals are\n1:Simple Goal\n2:Eternal Goal\n3:Checklist Goal\nWhich Type of Goal Would You Like to Create?");
        int activiNumber_G = Convert.ToInt32(Console.ReadLine());
        
        if (activiNumber_G == 1)
        {
            Simple s = new Simple();
            s.Elpmis();
            return;
        }

        else if (activiNumber_G == 2)
        {
            Eternal e = new Eternal();
            e.Lanrete();
            return;
        }

        else if (activiNumber_G == 3)
        {
            Checklist c = new Checklist();
            c.Tsilkcehc();
            return;
        }
        else
        {
            Console.WriteLine("Not what I asked, Shutting down.");
        }
    }
}