public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayContentWord()
    {
        if (_isHidden)
        {
            return new string('_', _text.Length);
            //loops through the word and replaces each character with an underscore
        }
        else
        {
            return _text;
        }
    }

}