class GameOfThrone
{
    /*
        s=aabbccdd
        One way this can be arranged into a palindrome is abcddcba. Return YES.
    */
    public static string gameOfThrones(string s)
    {
        if (s.Length <= 1)
            return "NO";
        Dictionary<char,int> dicLetterCount = s.ToArray().GroupBy(g => g).ToDictionary(d => d.Key, d => d.Count() % 2 );
        if (dicLetterCount.Where(x => x.Value == 1).Count() > 1)
            return "NO";
        return "YES";
    }
    public static void Run()
    {
        string s = "aabbccdd";
        string result = gameOfThrones(s);
        Console.WriteLine($"String '{s}' can be modified to palindrome: {result}");
    }
}