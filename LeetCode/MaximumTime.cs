class MaximumTime
{
    public static string maximumTime(string time) {
        string[] timeSplit = time.Split(':');
        string result = string.Empty;
        string hour = timeSplit[0];
        string minutes = timeSplit[1];

        if (hour[0] == '?' && hour[1] == '?')
            result += "23";
        else if (hour[0] == '?')
        {
            if (Char.GetNumericValue(hour[1]) < 4)
                result += $"2{hour[1]}";
            else
                result += $"1{hour[1]}";
        }
        else if (hour[1] == '?')
        {
            if (Char.GetNumericValue(hour[0]) < 2)
                result += $"{hour[0]}9";
            else
                result += $"{hour[0]}3";
        }
        else
            result += hour;

        result += ":";
        
        if (minutes[0] == '?' && minutes[1] == '?')
            result += "59";
        else if (minutes[0] == '?')
            result += $"5{minutes[1]}";
        else if (minutes[1] == '?')
            result += $"{minutes[0]}9";
        else
            result += minutes;
        return result;
    }

    public static void Run() {
        string time = "0?:3?";
        string result = maximumTime(time);
        Console.WriteLine($"Max time from string {time} is {result}");
    }
}