class TwoChars
{
    public static int alternate(string s)
    {
        char[] chars = s.Distinct().ToArray();
        int result = 0;
        for(int i=0; i<chars.Length; i++)
        {
            for(int j=0; j<chars.Length; j++)
            {
                if (j == i) continue;
                char[] twoCharString = s.Where(x => x.Equals(chars[i]) || x.Equals(chars[j])).ToArray();
                bool isValid = IsValid(twoCharString,chars[i],chars[j]);
                if (isValid && twoCharString.Length > result)
                    result = twoCharString.Length;
            }
        }
        return result;
    }

    private static bool IsValid(char[] chars,char char1, char char2)
    {
        for (int i=0; i<chars.Length; i++)
        {
            if (i%2 == 0)
            {
                if(chars[i] == char1)  
                    continue;
                return false;
            }
            else
            {
                if(chars[i] == char2)  
                    continue;
                return false;
            }
        }
        return true;
    }
    
    public static void Run()
    {
        string s = "abaacdabd";
        int cnt = alternate(s);
        Console.WriteLine($"The longest alternating letters from string={s} is {cnt}");
    }
}