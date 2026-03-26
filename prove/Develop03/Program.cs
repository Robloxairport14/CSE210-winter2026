using System;

class Program
{
    static void Main(string[] args)
    {
        string scriptureText = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
        Reference reference = new Reference("John", 3, 16);
        Scriptures scriptures = new Scriptures(reference, scriptureText);
        Random random = new Random();
        string input;
        do
        {
            Console.Clear();
            Console.WriteLine("Scripture:");
            Console.WriteLine(scriptures.GetDisplayContent());
            Console.WriteLine("\nPress Enter to hide words, or type 'quit' to exit.");
            input = Console.ReadLine();

            if (input.ToLower() != "quit")
            {
                scriptures.HideWords(1, random);
            }
            else if (input.ToLower() == "quit")
            {
                Console.WriteLine("Exiting the program. Goodbye!");
            }

        } while (input.ToLower() != "quit");
    }
}