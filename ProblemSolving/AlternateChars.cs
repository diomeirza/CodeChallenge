class AlternateChars
{
    /*
    You are given a string containing characters A and B only. 
    Your task is to change it into a string such that there are no matching adjacent characters. 
    To do this, you are allowed to delete zero or more characters in the string.
    Your task is to find the minimum number of required deletions.
    S = AABAAB
    Remove an A at positions 1 and 3 to make s = ABAB in 2 deletions.
    */
    public static int alternatingCharacters(string s)
    {
        char lookupChar = s[0];
        int deleted = 0;
        for (int i=1; i<s.Length; i++)
        {
            if (lookupChar.Equals(s[i]))
                deleted++;
            else
                lookupChar = s[i];
        }
        return deleted;
    }
    public static void Run()
    {
        string s = "BABABA";
        int result = alternatingCharacters(s);
        Console.WriteLine($"Need to remove {result} chars to make no matching adjacent characters from '{s}'");
    }
}