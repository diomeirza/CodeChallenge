class SeparateNumbers
{
    /*
        s = 1234
        return YES because it can be split into 1 difference number for each element : 1,2,3,4
        s = 99100
        return YES because it can be split into 1 difference number for each element : 99,100
        s = 101103
        return NO because it can't be split into 1 difference number
    */
    public static void separateNumbers(string s)
    {
        if(s.Length < 2)
        {
            Console.WriteLine($"NO");
            return;
        }

        int maxDigitFirstChars = s.Length/2;
        for (int i=1; i<= maxDigitFirstChars; i++)
        {
            bool IsBeautiful = IsIncrementOne(s,i);
            if (IsBeautiful)
            {
                Console.WriteLine($"YES {s.Substring(0,i)}");
                return;
            }
        }
        Console.WriteLine($"NO");
    }
    public static bool IsIncrementOne(string s,int countAsFirstDigit)
    {
        string firstDigit = s.Substring(0,countAsFirstDigit);
        long firstInt = Convert.ToInt64(firstDigit);
        long nextInt = firstInt;
        string str = firstDigit;
        while(str.Length < s.Length)
        {
            nextInt = nextInt + 1;
            str = string.Concat(str,nextInt);
        }
        return str.Equals(s);
    }

    public static void Run()
    {
        string s = "99999999999999999999999999999999";
        separateNumbers(s);
    }
}