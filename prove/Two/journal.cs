class Journal
{
    public List<Entry> _entries;

    public void WriteEntry()
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        Prompt rest=new Prompt();
        string toast=rest.GetQuestion();
        Console.WriteLine($"{toast}");
        Console.Write("answer:");
        string bank=Console.ReadLine();
        Entry e=new Entry();
        e._prompt=toast;
        e._data=dateText;
        e._text=bank;
        _entries.Add(e);
    }
    public void DisplayEntries()
    {
        
    }
    public void LoadEntries()
    {
        
    }
    public void SaveEntries()
    {
        
    }
    
}