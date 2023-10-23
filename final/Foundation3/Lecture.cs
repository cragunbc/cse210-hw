public class Lecture : Event
{
    private string _speaker;
    private int _quantity;


    public Lecture(string _eventTitle, string _description, string _date, string _time, Address _address, string _speaker, int _quantity) : base(_eventTitle, _description, _date, _time, _address)
    {
        this._speaker = _speaker;
        this._quantity = _quantity;
    }

    public string GetFullDetails()
    {
        return $"\nType: {GetType()}{StandardDetails()}\nSpeaker: {_speaker}\nQuantity: {_quantity}";
 
    }
}