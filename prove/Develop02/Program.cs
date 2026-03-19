using System;

class Program
{
    static void Main(string[] args)
    {
        Prompt test=new Prompt();
        string toust=test.GetQuestion();
        Entry three=new Entry();
        three._data="3/17/2026";
        three._prompt=toust;
        three._text="I'm alive";

        three.Display();
        // Console.WriteLine($"{toust}");
    }
}