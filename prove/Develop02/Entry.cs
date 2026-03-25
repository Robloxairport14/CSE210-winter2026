using System.IO;
public class Entry
{
    public DateTime _date;
    public string _prompt;
    public string _response;
    public Entry() { }
    // empty Constructor to try or test later
    public Entry(DateTime date, string prompt, string response)
    {
        _date = date;
        _prompt = prompt;
        _response = response;
    }
    public void Display()
    {
        Console.WriteLine($"Date: {_date} Prompt: {_prompt} Response: {_response}");
    }
    public void GetEntryAsString(string fileName = "journal.txt")
    {
        using (StreamWriter outputFile = new StreamWriter(fileName, true))
        {
            outputFile.WriteLine($"{_date} | {_prompt} | {_response}");
        }
    }
}