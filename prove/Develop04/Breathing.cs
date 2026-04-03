using System.Diagnostics.CodeAnalysis;
using System.Runtime.Intrinsics.Wasm;

class Breathing : Activity
{
    private int _exhale;
    private int _inhale;

    public void Start()
    {
        Console.WriteLine(_name);
        Console.WriteLine(_desc);
        PromptDuration();
        // Console.WriteLine("How many times should the air move?:");
        // int auntswer = Convert.ToInt32(Console.ReadLine());
        int quantity = _duration / (_inhale + _exhale);
        while (quantity != 0)
        {
            Animation ($"Breathe in", _inhale);
            Animation ($"Breathe out", _exhale);
            quantity -=1;
        }
        Console.WriteLine($"{_closingMsg}");
    }

    public Breathing() //constructor
    {
        _name = "O2";
        _desc = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        _inhale = 4;
        _exhale = 4;
        _closingMsg = "Thak you for participating in option 1, Breathing.";
    }

    public int GetInale()
    {
        return _inhale;
    }

    public int GetExale()
    {
        return _exhale;
    }
}