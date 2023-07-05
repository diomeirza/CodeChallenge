class Subject
{
    public delegate void EventHandler(string args);
    public event EventHandler? Notify;
    
    public void Change(string message)
    {
        Notify?.Invoke(message);
    }
}

class Subject2
{
    public Action<string>? Notify;
    
    public void Change(string message)
    {
        Notify?.Invoke(message);
    }
}