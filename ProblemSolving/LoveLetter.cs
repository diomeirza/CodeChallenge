class LoveLetter
{
    /*
        To do this, he follows two rules:
        He can only reduce the value of a letter by 1, i.e. he can change d to c, but he cannot change c to d or d to b.
        The letter a may not be reduced any further.
        s = cde
        The following two operations are performed: cde → cdd → cdc. Return 2.
    */
    public static int theLoveLetterMystery(string s)
    {
        int result = 0;
        for(int i=0; i<s.Length/2; i++)
        {
            if(s[i] == s[s.Length-1-i])
                continue;
            int ascii1 = (int) s[i];
            int ascii2 = (int) s[s.Length-1-i];
            result += Math.Abs(ascii1-ascii2);
        }
        return result;
    }
    public static void Run()
    {
        string s = "abcd";
        int result = theLoveLetterMystery(s);
        Console.WriteLine($"Need to reduce {result} times to create palindrome from string '{s}'");
    }
}