
class Word
{
    private string _text;
    private bool _isHidden;


    public Word(string text) // Constructor to initialize attributes
    { 
        _text = text;
        _isHidden = false;
    }

    public string Display() // Return word, not Write
    {
        if (_isHidden == true)
        {
            return new string('_', _text.Length);
        }
        else
        {
            return _text;
        }
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public bool IsHidden()
    {
        if (_isHidden == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}