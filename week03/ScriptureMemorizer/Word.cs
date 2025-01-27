public class Word
{
    private string _text;
    private bool _isHidden;

    public bool IsHidden => _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public string Render()
    {
        return _isHidden ? new string('_', _text.Length) : _text;
    }
}
