class HackerrankString
{
    public static string hackerrankInString(string s)
    {
        string keyword = "hackerrank";
        int index = 0;
        foreach (char item in keyword)
        {
            int pos = s.IndexOf(item, index);
            if (pos < index)
                return "NO";
            index = pos + 1;
        }
        return "YES";
    }

    public static void CheckHackerrankString()
    {
        string param = "hackerworld";
        string isHackerrank = hackerrankInString(param);
        Console.WriteLine($"string {param} is {isHackerrank} hackerrank string.");
    }
}