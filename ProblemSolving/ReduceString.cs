class ReduceString
{
    /*  Example.
        s = "aab"
        aab shortens to b in one operation: remove the adjacent a characters.
    */
    public static string superReducedString(string s)
    {
        string result = string.Empty;
        int i = 0;
        while (i < s.Length)
        {
            if (i < s.Length -1 && s[i] == s[i+1])
            {
                i+=2;
            }
            else
            {
                if (string.IsNullOrEmpty(result) || result[result.Length-1] != s[i])
                {
                    result = $"{result}{s[i]}";
                }
                else 
                {
                    result = result.Substring(0,result.Length -1);
                }
                i++;
            }
        }
        return (string.IsNullOrEmpty(result) ? "Empty String" : result);
    }
    public static void Run()
    {
        string s = "baab";
        string result = superReducedString(s);
        Console.WriteLine($"Remove a pair of adjacent letter from '{s}' is '{result}'");
    }
}