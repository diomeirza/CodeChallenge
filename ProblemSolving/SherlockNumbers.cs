class SherlockNumbers
{
    /*
        n : number of digit to create decent number
        A Decent Number has the following properties:
        Its digits can only be 3's and/or 5's.
        The number of 3's it contains is divisible by 5.
        The number of 5's it contains is divisible by 3.
        It is the largest such number for its length.
        n = 3
        decent number = 555 (there are 3 5's and it can be divided by 3)
        n = 8
        decent number = 55533333
        print -1 if can't create decent number otherwise print decent number
    */
    public static void decentNumber(int n)
    {
        int countThrees = 0;
        int countFives = 0;
        for (int i = countThrees; i <= n; i = i + 5)
        {
            for (int j = countFives; i + j <= n; j = j + 3)
            {
                if (i + j == n)
                {
                    countThrees = i;
                    countFives = j;
                }
            }
        }
        if (countFives == 0 && countThrees == 0)
        {
            Console.WriteLine(-1);
            return;
        }
        string result = string.Empty;
        result = result.PadLeft(countFives,'5');
        result = result.PadRight(n,'3');
        Console.WriteLine(result);
    }
    public static void Run()
    {
        int n = 15;
        decentNumber(n);
    }
}