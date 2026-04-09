using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"You have {Point} points.");
        Console.WriteLine("");
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1:Creating New Goal\n2:List Goals\n3:Save Goals\n4:Load Goals\n5:Record Event\n6:Quit");
        int activiNumber = Convert.ToInt32(Console.ReadLine());
        
        if (activiNumber == 1)
        {
            Goal goal = new Goal();
            goal.Start();
            return;
        }
        
        else if (activiNumber == 2)
        {
            Console.WriteLine($"The goals are:\n{List}");
            return;
        }

        else if (activiNumber == 3)
        {
            Console.WriteLine("What is the file name for the goal file?");
            string file = Console.ReadLine();
        }

        else if (activiNumber == 4)
        {
            Console.WriteLine("What is the file name for the goal file?");
            string Load = Console.ReadLine();
        }

        else if (activiNumber == 5)
        {
            Console.WriteLine($"The goals are:\n{List}\nWhich goal did you accomplish?");
            int done = Convert.ToInt32(Console.ReadLine());
            if (done == )
            {
                
            }
            return;
        }

        else if (activiNumber == 6)
        {
            Console.WriteLine("bye bye");
            
        }

        else
        {
            Console.WriteLine("I did not gave you this option, shutting down.");
            
        }
        
    }
}