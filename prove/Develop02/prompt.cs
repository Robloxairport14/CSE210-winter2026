class Prompt
{
    public List<string> _questions= [
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"];
    public string GetQuestion()
    {
        Random r=new Random();
        int outdex=r.Next(0,5);
        string result=_questions[outdex];
        return result;
    }

}