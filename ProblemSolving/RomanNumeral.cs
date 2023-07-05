class RomanNumeral
{
    public static string RomanNumeralReduction(string str)
    {

        // code goes here  
        int numeral = GetNumeral(str);
        string reducedStr = string.Empty;
        Dictionary<char, int> romanDic = new Dictionary<char, int>();
        romanDic.Add('M', 1000);
        romanDic.Add('D', 500);
        romanDic.Add('C', 100);
        romanDic.Add('L', 50);
        romanDic.Add('X', 10);
        romanDic.Add('V', 5);
        romanDic.Add('I', 1);

        foreach (var item in romanDic)
        {
            int divisor = numeral / item.Value;
            for (int i = 0; i < divisor; i++)
            {
                reducedStr = string.Concat(reducedStr, item.Key);
            }
            numeral = numeral % item.Value;
        }

        return reducedStr;

    }

    public static int GetNumeral(string str)
    {
        int result = 0;
        foreach (var item in str)
        {
            if (item == 'I')
                result += 1;
            else if (item == 'V')
                result += 5;
            else if (item == 'X')
                result += 10;
            else if (item == 'L')
                result += 50;
            else if (item == 'C')
                result += 100;
            else if (item == 'D')
                result += 500;
            else if (item == 'M')
                result += 1000;
        }
        return result;
    }

    public static void Run()
    {
        string input = "DDLL";
        string result = RomanNumeralReduction(input);
        Console.WriteLine(result);
    }
}