class FunnyString
{
    /*
    Test Case 0:
    s = acxz, r = zxca 
    Corresponding ASCII values of characters of the strings:
    s = [97,99,120,122] and r = [122,120,99,97]
    For both the strings the adjacent difference list is [2, 21, 2].
    which is funny
    Test Case 1:
    s = bcxz, r = zxcb
    Corresponding ASCII values of characters of the strings:
    s = [1,21,2] and r = [2,21,1] 
    The difference list for string  is [1, 21, 2] and for string  is [2, 21, 1].
    which is not funny
    */
    public string funnyString(string s)
    {
        char[] chars = s.ToArray();
        int lenChars = chars.Length;
        for (int i = 0; i < lenChars - 1; i++)
        {
            int diff1 = (int)chars[i + 1] - (int)chars[i];
            int diff2 = (int)chars[lenChars - 1 - i] - (int)chars[lenChars - 2 - i];
            if (Math.Abs(diff1) != Math.Abs(diff2))
            {
                return "Not Funny";
            }
        }
        return "Funny";
    }
}