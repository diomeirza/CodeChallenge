class Test
{
    public static int CalculateWordScore(string word)
    {
        string alphabets = "abcdefghijklmnopqrstuvwxyz";
        int result = 0;
        foreach (var item in word.ToLower())
        {
            int index = alphabets.IndexOf(item);
            if (index < 0)
                return -1;

            result += index + 1;
        }
        return result;
    }
    public static void Run()
    {
        string word = "Hello World";
        Console.WriteLine(CalculateWordScore(word));
        int result = FormatNumber(2);
        Console.WriteLine(result);
    }

    public static int FormatNumber(int number)
    {
        var binaryRep = string.Empty;
        var result = 0;
        while (number > 0)
        {
            binaryRep = (number % 2) + binaryRep;
            number = number / 2;
        }

        int base1 = 1;
        int len = binaryRep.Length;
        for (int i = 0; i <len; i++)
        {
            if (binaryRep[i] == '1')
                result += base1;
            base1 = base1 * 2;
        }

        return result;
    }
}
