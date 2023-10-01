public class Scripture
{
    private List<Word> _words = new List<Word>();
    private Reference _reference;
    private Random rnd = new();
    

    public Scripture(Reference _reference, string _text)
    {
        this._reference = _reference;
        string[] wordArray = _text.Split();
        foreach (string word in wordArray)
        {
            Word wordObject = new Word(word);
            _words.Add(wordObject);
        }
    }

    public void HideRamdomWords(int numberToHide)
    {
        // counter = 0
        // DO
        //      index = rnd.next( length of words)
        //      if words[index].Hidden is false
        //          words[index].Hidden = true
        //          counter++
        //
        // While counter < numberToHide AND IsCompletelyHidden() is false

        int counter = 0;
        do
        {
            int index = rnd.Next(_words.Count);
            if (!_words[index].Hidden)
            {
                _words[index].Hidden = true;
                counter ++;
            }
        }
        while (counter < numberToHide && !IsCompletelyHidden());
    }

    public void GetDisplayText()
    {
        // Loop through the words list (foreach)
        //      print word.GetDisplaytext() *also print white space for spacing
        Console.Write($"{_reference.GetDisplayText()} \"");

        foreach (Word word in _words)
        {
           Console.Write($"{word.GetDisplayText()} ");
        }
        Console.WriteLine("\b\"");
    }

    public bool IsCompletelyHidden()
    {
        // Loop through the words list
        //      check if the word (word object) is hidden by calling the property (word.Hidden)
        //      return false
        // return true

        foreach (Word word in _words)
        {
            if(!word.Hidden)
            {
                return false;
            }
        }

        return true;
    }
}