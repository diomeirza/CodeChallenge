class TwoStrings
{
    /*
        Given two strings, determine if they share a common substring. A substring may be as small as one character.
        Example
        s1 = and
        s2 = art
        These share the common substring a. Return YES otherwise return No
    */
    public static string twoStrings(string s1, string s2)
    {
        
        for(int i=0; i<s1.Length; i++)
        {
            if(s2.IndexOf(s1[i]) >= 0)
                return "YES";
        }
        return "NO";
    }
    public static void Run()
    {
        string s1 = "and";
        string s2 = "art";
        string result = twoStrings(s1,s2);
        Console.WriteLine($"String '{s1}' and string '{s2}' have a common substring: {result}");
    }
}