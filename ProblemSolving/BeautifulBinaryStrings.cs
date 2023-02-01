class BeautifulBinaryStrings
{
    /*
        A binary string is beautiful if and only if it doesn't contain the substring "010".
        In one step, Alice can change a 0 to a 1 or vice versa. 
        Count and print the minimum number of steps needed to make the string as beautiful. 
        S = "0101010"
        return 2
    */
    public static int beautifulBinaryString(string b)
    {
        string notBeautiful = "010";
        int indexNotBeautiful = b.IndexOf(notBeautiful);
        if (indexNotBeautiful < 0)
            return 0;
        int count010 = 0;
        while (indexNotBeautiful >= 0)
        {
            b = b.Substring(indexNotBeautiful + notBeautiful.Length);
            count010++;
            indexNotBeautiful =  b.IndexOf(notBeautiful);
        }
        return count010;
    }
    public static void Run()
    {
        string s = "0101010";
        int result = beautifulBinaryString(s);
        Console.WriteLine($"String {s} can be beautiful with {result} steps");
    }
}