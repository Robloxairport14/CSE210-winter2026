class Reflection : Activity
{

    public Reflection() //constructor
    {
        _name = "Mirror";
        _closingMsg = "Thak you for participating in option 2, Reflection.";
        _desc = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    public void Strict() //start
    {
        Console.WriteLine($"{_name}");
        Console.WriteLine($"{_desc}");
        int result = Dice(4);

        if (result == 1)
            Console.WriteLine("Think of a time when you stood up for someone else.");

        else if (result == 2)
            Console.WriteLine("Think of a time when you did something really difficult.");

        else if (result == 3)
            Console.WriteLine("Think of a time when you helped someone in need.");

        else if (result == 4)
            Console.WriteLine("Think of a time when you did something truly selfless.");

        PromptDuration();
        Animation("Now, I'll give you some time to ponder, and when pondering time is up, then I'll show you a list of questions to reflect on based out of the duration you requested", 3);
        DateTime startTime = DateTime.Now;
        DateTime finishTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < finishTime)
        {
            result = Dice(9);

            if (result == 1)
                Animation("Why was this experience meaningful to you?", 3);
            else if (result == 2)
                Animation("Have you ever done anything like this before?", 3);
            else if (result == 3)
                Animation("How did you get started?", 3);
            else if (result == 4)
                Animation("How did you feel when it was complete?", 3);
            else if (result == 5)
                Animation("What made this time different than other times when you were not as successful?", 3);
            else if (result == 6)
                Animation("What is your favorite thing about this experience?", 3);
            else if (result == 7)
                Animation("What could you learn from this experience that applies to other situations?", 3);
            else if (result == 8)
                Animation("What did you learn about yourself through this experience?", 3);
            else if (result == 9)
                Animation("How can you keep this experience in mind in the future?", 3);
            
        }

        

        Console.WriteLine($"{_closingMsg}");
    }
}