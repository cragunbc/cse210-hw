using System.Reflection.PortableExecutable;

public class Word
{
    private string _text;
    private bool _isHidden;

    public string Text
    {
        get {return _text;}  
    }

    public bool Hidden
    {
        get {return _isHidden;}
        set {_isHidden = value;}
    }


    public Word(string _text)
    {
        this._text = _text;
        _isHidden = false;
    }

    public string GetDisplayText()
    {
        if (_isHidden)
        {
            string hiddenWord = "";
            foreach (char letter in _text)
            {
                hiddenWord += "_";
            }
            return hiddenWord;
        }
        else
        {
            return _text;
        }
        
    }
}