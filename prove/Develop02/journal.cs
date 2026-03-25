public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    
    public void DisplayAllEntries()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries found.");
            return;
        }

        Console.WriteLine("Displaying all journal entries:");
        foreach (Entry item in _entries)
        {
            item.Display();
        }
    }
    

}