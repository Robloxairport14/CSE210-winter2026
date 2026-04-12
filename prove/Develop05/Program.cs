using System;

class Program
{
    static void Main(string[] args)
    {
        int point =0;
        List<Goal> all= new List<Goal>();
        while (true)
        {
            Console.WriteLine($"You have {point} points.");
            Console.WriteLine("");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1:Creating New Goal\n2:List Goals\n3:Save Goals\n4:Load Goals\n5:Record Event\n6:Quit");
            int activiNumber = Convert.ToInt32(Console.ReadLine());

            if (activiNumber == 1)
            {
                Goal goal = Goal.Start();
                if (goal == null)
                {
                    Console.WriteLine("Fail to create!");
                }
                else
                {
                    all.Add(goal);
                }
            }

            else if (activiNumber == 2)
            {
                Console.WriteLine($"The goals are:");
                for (int i = 0; i < all.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {all[i]}");
                }
            }

            else if (activiNumber == 3)
            {
                Console.WriteLine("What is the file name for the goal file?");
                string file = Console.ReadLine();
                File.WriteAllText(file, "");
            }

            else if (activiNumber == 4)
            {
                Console.WriteLine("What is the file name for the goal file?");
                string Load = Console.ReadLine();
            }

            else if (activiNumber == 5)
            {
                Console.WriteLine("What is the file name for the goal file?");
                string finish = Console.ReadLine();
                using (StreamWriter output = new StreamWriter("goals.txt"))
                {
                    for (int i = 0; i < all.Count; i++)
                    {
                        int number = i + 1; // makes it 1–5 instead of 0–4
                        output.WriteLine($"{number}. {all[i].ToString()}");
                    }
                }
                // Console.WriteLine($"The goals are:\n{List}\nWhich goal did you accomplish?");
                int done = Convert.ToInt32(Console.ReadLine());
                // if (done == )
                {

                }
                object g="";
                if(g.GetType().Name=="Simple")
                {
                    // simple goal diplay method
                }
                else if (g.GetType().Name=="Eternal")
                {
                    //Eternal goal diplay method
                }
                else if (g.GetType().Name=="Checklist")
                {
                    //Checklist goal diplay method
                }
            }

            else if (activiNumber == 6)
            {
                Console.WriteLine("bye bye");
                break;
            }

            else
            {
                Console.WriteLine("I did not gave you this option, shutting down.");
                break;
            }
        }
        
    }
}