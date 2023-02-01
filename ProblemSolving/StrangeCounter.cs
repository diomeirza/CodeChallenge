class StrangeCounter
{
    /* There is a strange counter. 
    At the first second, it displays the number 3. 
    Each second, the number displayed by decrements by 1 until it reaches 1. 
    In next second, the timer resets to 2 X the initial number and continues counting down.
    t = 1 
    output = 3
    t = 2
    output = 2
    t = 3
    output = 1
    t = 4
    output = 6
    */
    public static long strangeCounter(long t)
    {
        int cycle = 1;
        long initialTime = 1;
        long prevInitTime = 0;
        long initialValue = 3;
        while(initialTime <= t)
        {
            prevInitTime = initialTime;
            initialTime = (long) (initialTime + 3 * Math.Pow(2,cycle-1));
            initialValue = initialValue * 2;
            cycle++;
            
        }
        initialTime = prevInitTime;
        long initialValueInCycle = initialValue/2;
        return initialValueInCycle - (t-initialTime);
    }

    public static long workButSlow(long t)
    {
        long initial = 3;
        long result = initial;
        for(long i=1; i<t; i++)
        {
            if (result==1)
            {
                initial = initial * 2;
                result = initial;
            }
            else
            {
                result--;
            }
        }
        return result;
    }

    public static void CountStrange()
    {
        long t = 21;
        long cnt = strangeCounter(t);
        Console.WriteLine($"The strange counter at time {t} is {cnt}");
    }
}