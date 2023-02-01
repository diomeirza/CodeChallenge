class TimeConversion
{
    public static string timeConversion(string s)
    {
        string[] time = s.Split(":");
        int hour = Convert.ToInt32(time[0]);
        string minutes = time[1];
        string seconds = time[2].Substring(0,2);
        string AmPm = time[2].Substring(2);
        int convertedHour = (hour % 12);
        if (AmPm.Equals("PM"))
        {
            convertedHour = convertedHour + 12;        
        }
        return $"{convertedHour.ToString().PadLeft(2,'0')}:{minutes}:{seconds}";
    }

    public static void TestTimeConversion()
    {
        string s = "12:01:00AM";
        string convertedTime = timeConversion(s);
        Console.WriteLine($"24H format from {s} is {convertedTime}");
    }
}