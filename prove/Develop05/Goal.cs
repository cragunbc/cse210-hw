using System.Collections.Concurrent;
using System.Drawing;

public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    protected bool _isComplete;

    public Goal(string _name, string _description, int _points)
    {
        this._name = _name;
        this._description = _description;
        this._points = _points;
        _isComplete = false;
    }
    public Goal(string _name, string _description, int _points, bool _isComplete)
    {
        this._name = _name;
        this._description = _description;
        this._points = _points;
        this._isComplete = _isComplete;
    }
    public abstract int RecordEvent();

    public virtual string GetDetailsString()
    {
        char _;
        if(_isComplete)
            _ = 'X';
        else
            _ = ' ';
        return $"[{_}] {_name} ({_description})";
    }

    public abstract string GetSaveString();
}