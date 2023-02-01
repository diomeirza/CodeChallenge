class SubstactDatetime
{
    public static void Run()
    {
        DateTime a = new DateTime(2022, 1, 1, 23, 0, 0);
        DateTime b = new DateTime(2022, 1, 3, 2, 0, 0); 
        int iterations = GetIteration(a, b);
        Console.WriteLine($"datetime {a} and {b} have {iterations} iterations");
        int correct = GetCorrectIteration(a, b);
        Console.WriteLine($"correct iterations {correct}");
        // a = new DateTime(2022, 1, 1, 5, 0, 0);
        // b = new DateTime(2022, 1, 1, 12, 0, 0);
        // iterations = GetIteration(a, b);
        // Console.WriteLine($"datetime {a} and {b} have {iterations} iterations");
        // correct = GetCorrectIteration(a, b);
        // Console.WriteLine($"correct iterations {correct}");
    }

    public static int GetIteration(DateTime origBegTime, DateTime origEndTime)
    {
        var tsinminutes = (origEndTime.Subtract(origBegTime));
        int iterations = (tsinminutes.Days * 24 * 60 + tsinminutes.Hours * 60 + tsinminutes.Minutes) / (60 * 24);

        if (tsinminutes.TotalDays > iterations && origBegTime.Day != origEndTime.Day &&
           origBegTime.Day != origEndTime.AddSeconds(-5).Day)
        {
            iterations++;
        }
        if (origBegTime.Date != origBegTime)
        {
            iterations++;
        }
        else if (origBegTime.Date == origEndTime.Date)
        {
            iterations++;
        }
        return iterations;
    }
    public static int GetCorrectIteration(DateTime origBegTime, DateTime origEndTime)
    {
        int iterations = (int) (origEndTime.Date - origBegTime.Date).TotalDays; 
        if (origEndTime.Hour > 0)
            iterations++;
        return iterations;
    }
}