using System.IO;

class Program
{
    static void Main(string[] args)
    {

        string userInput = "";

        Journal myJournal = new Journal();

        while (userInput != "5")
        {
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Type '1' to add a new entry.");
            Console.WriteLine("Type '2' to display all entries.");
            Console.WriteLine("Type '3' to save entries to a file.");
            Console.WriteLine("Type '4' to load entries from a file.");
            Console.WriteLine("Type '5' to exit the program.");
            Console.Write("Please enter your selection: ");
            userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    PromptGenerator p1 = new PromptGenerator();
                    string prompt = p1.GetRandomPrompt();
                    Console.WriteLine($"{prompt}");

                    string userResponse = Console.ReadLine();
                    DateTime currentTime = DateTime.Now;
                    Entry newEntry = new Entry(currentTime, prompt, userResponse);
                    myJournal._entries.Add(newEntry);
                    break;
                case "2":
                    myJournal.DisplayAllEntries();
                    break;
                case "3":
                    Console.WriteLine("Enter the filename to save your entries (default is 'journal.txt'): ");
                    string fileName = Console.ReadLine();
                    File.WriteAllText(fileName, "");

                    foreach (Entry entry in myJournal._entries)
                    {
                        entry.GetEntryAsString(fileName);
                    }
                    break;
                case "4":
                    myJournal._entries.Clear();
                    Console.WriteLine("Enter the filename to load your entries from (default is 'journal.txt'): ");
                    string fileName2 = Console.ReadLine();
                    string[] lines = File.ReadAllLines(fileName2);
                    //all the lines and entries

                    foreach (string line in lines)
                    {
                        string[] parts = line.Split('|');
                        // individual entry parts
                        if (parts.Length == 3)
                        {
                            DateTime date = DateTime.Parse(parts[0].Trim());
                            string promptText = parts[1].Trim();
                            string responseText = parts[2].Trim();
                            Entry entry = new Entry(date, promptText, responseText);
                            myJournal._entries.Add(entry);
                        }
                    }
                    break;
                case "5":
                    Console.WriteLine("Exiting the program. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid selection. Please try again.");
                    break;
            }
        }
    }
}