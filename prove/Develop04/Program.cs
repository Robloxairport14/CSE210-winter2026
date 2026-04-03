using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What activity will you choose?\n1:Breathing\n2:Reflection\n3:Listing");
        int activiNumber = Convert.ToInt32(Console.ReadLine());
        
        if (activiNumber == 1)
        {
            Console.WriteLine(" you have chosen Breathing");
            Breathing breathing = new Breathing();
            breathing.Start();

        }
        
        else if (activiNumber == 2)
        {
            Console.WriteLine(" you have chosen #2");
            
            Reflection reflection = new Reflection();
            reflection.Strict();
        }

        else if (activiNumber == 3)
        {
            Console.WriteLine(" you have chosen #3");
            Listing listing = new Listing();
            listing.Startch();
        }

        else
        {
            Console.WriteLine("I did not gave you this option, shutting down.");
            
        }
    }
}