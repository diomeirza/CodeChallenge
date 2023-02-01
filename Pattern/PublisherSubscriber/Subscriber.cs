class Subscriber
{
    public void Subscribe1()
    {
        Console.WriteLine("Subsciber 1 is joined");
    }
    public void Subscribe2()
    {
        Console.WriteLine("Subsciber 2 is joined");
    }

    public void Subscribe3(Citizen ctz)
    {
        Console.WriteLine($"Subsciber 3 with name = {ctz.Name} and age = {ctz.Age} is joined");
    }


}