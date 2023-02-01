class StrongPassword
{
    /*
        The website considers a password to be strong if it satisfies the following criteria:
        Its length is at least 6.
        It contains at least one digit.
        It contains at least one lowercase English character.
        It contains at least one uppercase English character.
        It contains at least one special character. The special characters are: !@#$%^&*()-+
        find the minimum number of characters she must add to make her password strong
    */
    public static int minimumNumber(int n, string password)
    {
        int countInvalid = 0;
        char[] chars = password.ToArray();
        string specials = "!@#$%^&*()-+";
        string numbers = "0123456789";
        string lower_case = "abcdefghijklmnopqrstuvwxyz";
        string upper_case = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        bool isDigitExist = chars.Any(x => numbers.Contains(x));
        bool isLowerCaseExist = chars.Any(x => lower_case.Contains(x));
        bool isUpperCaseExist = chars.Any(x => upper_case.Contains(x));
        bool isSpecialExist = chars.Any(x => specials.Contains(x));
        
        if (!isLowerCaseExist)
            countInvalid++;
        if (!isUpperCaseExist)
            countInvalid++;
        if (!isSpecialExist)
            countInvalid++;
        if (!isDigitExist)
            countInvalid++;
        if (n < 6)
        {
            int diff = 6 - n;
            if (diff >= countInvalid)
                return diff;
        }   
            
        return countInvalid;
    }

    public static void Run()
    {
        int n = 11;
        string password = "#HackerRank";
        int cnt = minimumNumber(n, password);
        Console.WriteLine($"Password : {password} can make it strong by add {cnt} characters.");
    }
}