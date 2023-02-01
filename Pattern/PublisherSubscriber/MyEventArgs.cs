class MyEventArgs: EventArgs
{
    public Citizen citizen { get; set; }
    public MyEventArgs(Citizen ctz)
    {
        citizen = ctz;
    }    
}

class Citizen
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Citizen(string name, int age)
    {
        Name = name;
        Age = age;
    }
}