public class Scriptures
{
    private List<Word> _words = new List<Word>();
    private Reference _reference;
    private string _scriptureText;

    public Scriptures(Reference reference, string scripture)
    {
        _reference = reference;
        _scriptureText = scripture;
        string[] wordArray = _scriptureText.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        foreach (string word in wordArray)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideWords(int count, Random random)
    {
        int hiddenCount = 0;

        while (hiddenCount < count)
        {
            int index = random.Next(_words.Count);
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                hiddenCount++;
            }
        }
    }

    public string GetDisplayContent()
    {
        return $"{_reference.GetDisplayContentReference}: {string.Join(" ", _words.Select(w => w.GetDisplayContentWord()))}";
    }
}