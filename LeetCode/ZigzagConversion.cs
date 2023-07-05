class ZigzagConversion
{
    public static string Convert(string s, int numRows)
    {
        List<string> zigzagString = new List<string>();
        int y = 0;
        bool verticalDown = true;
        for (int i = 0; i < s.Length; i++)
        {
            if (i < numRows)
            {
                zigzagString.Add(s[i].ToString());
            }
            else
            {
                string item = s[i].ToString();
                zigzagString[y] += item;
            }

            if (y == numRows - 1)
                verticalDown = false;
            else if (y == 0)
                verticalDown = true;

            if (verticalDown)
            {
                if (y < numRows-1) y++;
            }
            else
            {
                if (y>0) y--;
            }

        }
        string result = string.Empty;
        foreach (var item in zigzagString)
        {
            result = $"{result}{item}";
        }
        return result;
    }

    public static void Run()
    {
        string s = "PAYPALISHIRING";
        // string s = "AB";
        int numRows = 3;
        string result = Convert(s, numRows);
        Console.WriteLine($"Zigzag conversion from {s} is: {result}");
    }
}