class LadyBug
{
    public static string happyLadybugs(string b)
    {
        char[] chars = b.ToArray();
        Dictionary<char,int> result = chars.Where(w => w != '_')
                        .GroupBy(g => g)
                        .ToDictionary(x => x.Key, y => y.Count());
        bool isCharOnlyOneExists = result.Any(x => x.Value <= 1);
        if (isCharOnlyOneExists)
            return "NO";

        int countUnderscore = b.Where(x => x == '_').Count();
        if (countUnderscore == 0)
        {
            if(chars[0] != chars[1] || chars[chars.Length-2] != chars[chars.Length-1])
                return "NO";
                
            for(int i=1; i<chars.Length-1; i++)
            {
                if(chars[i] != chars[i-1] && chars[i] != chars[i+1])
                    return "NO";
            }
        }   
        
        return "YES";
    }

    public static void LadyBugIsHappy()
    {
        string b = "AABCBC";
        string isHappy = happyLadybugs(b);
        Console.WriteLine($"string {b} is {isHappy} happy");
        b = "AABBCC";
        isHappy = happyLadybugs(b);
        Console.WriteLine($"string {b} is {isHappy} happy");
    }
}