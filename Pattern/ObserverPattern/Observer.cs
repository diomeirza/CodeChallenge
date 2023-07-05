class Observer
{
    private string _name;
    public Observer(string name, Subject2 sbj)
    {
        _name = name;
        sbj.Notify += Update;
    }

    public void Update(string message)
    {
        Console.WriteLine($"{_name} received: {message}");
    }

}