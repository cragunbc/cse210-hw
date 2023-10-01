public class Reference
{
    // variables Attributes Fields
    private string _book;
    private string _chapter;
    private string _startVerse;
    private string _endVerse;

    public Reference(string _book, string _chapter, string _startVerse)
    {
        this._book = _book;
        this._chapter = _chapter;
        this._startVerse = _startVerse;

    }

    public Reference(string _book, string _chapter, string _startVerse, string _endVerse)
    {
        this._book = _book;
        this._chapter = _chapter;
        this._startVerse = _startVerse;
        this._endVerse = _endVerse;
    }

    public string GetDisplayText()
    {
        if (_endVerse == null)
        {
            return $"{_book} {_chapter}:{_startVerse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        }
    }
}

