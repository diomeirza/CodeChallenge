class CamelCase
{
    /*
    s = oneTwoThree
    There are  words in the string: 'one', 'Two', 'Three'.
    */
    public static int camelcase(string s)
    {
        int aAscii = (int) 'a';
        return s.ToArray().Where(x => (int) x < aAscii).Count() + 1;
    }

    public static void DoCamelCase()
    {
        string s = "oneTwoThree";
        int countWord = camelcase(s);
        Console.WriteLine($"{s} has {countWord} words");
    }
}