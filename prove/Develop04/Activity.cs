using System.Xml;

class Activity
{
    protected string _name;
    protected string _desc; //description
    protected int _duration;
    protected string _closingMsg;
    protected string _question;
    public void PromptDuration()
    {
        Console.WriteLine("What should the duration in seconds be?:");
        string answer = Console.ReadLine();
        if (!int.TryParse(answer, out _duration))
        {
            if (_duration % 2 == 0)
            {
                _duration = 4;
            }

            else if (_duration % 2 != 0)
            {
                Console.WriteLine("I said even, not odd!");
                return;
            }

            else
            {
                _duration = 4;    //Default 4 second for invalid input
            }
        }

    }

    public int GetDuration()
    {
        return _duration;
    }

    public void Animation(string message, int time)
    {
        Console.WriteLine($"{message}");
        for (int i = time; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public int Dice(int max)
    {
        Random rnd = new Random();
        int number = rnd.Next(1, max+1); // 1 to 9
        return number;
    }

}