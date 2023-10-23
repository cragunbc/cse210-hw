public class Reception : Event
{
    private string _email;


    public Reception(string _eventTitle, string _description, string _date, string _time, Address _address, string _email) : base(_eventTitle, _description, _date, _time, _address)
    {
        this._email = _email;
    }



    public string GetFullDetails()
    {
        return $"\nType: {GetType()}{StandardDetails()}\nEmail: {_email}";

    }
}