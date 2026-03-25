using System.IO;
public class Entry
{
    public string _text;
    public string _data;
    public string _prompt;
    
    public void Display()
    {
        Console.WriteLine($"{_prompt}");
        Console.WriteLine($"{_text}");
        Console.WriteLine($"{_data}");
    }
}