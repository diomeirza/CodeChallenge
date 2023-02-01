using System.Text;

class PalindromeIndex
{
    /*
        s = "bcbc"
        Either remove 'b' at index 0 or 'c' at index 3.
    */
    public static int palindromeIndex(string s)
    {
        char[] t = s.ToArray();
        Array.Reverse(t);
        string reverseText = new string(t);
        if (s.Equals(reverseText))
            return -1;
        for (int i = 0; i < s.Length / 2; i++)
        {
            if (s[i] == s[s.Length - 1 - i])
                continue;
            
            int index = i;
            string temp = s.Remove(index, 1);
            string reverseTemp = reverseText.Remove(s.Length - 1 - index, 1);
            if (temp.Equals(reverseTemp))
                return index;

            index = s.Length - 1 - i;
            temp = s.Remove(index, 1);
            reverseTemp = reverseText.Remove(s.Length - 1 - index, 1);
            if (temp.Equals(reverseTemp))
                return index;
        }
        return -1;
    }
    public static int palindromeIndex_TimeOut(string s)
    {
        char[] t = s.ToArray();
        Array.Reverse(t);
        string reverseText = new string(t);
        if (s.Equals(reverseText))
            return -1;
        for (int i = 0; i < s.Length; i++)
        {
            string temp = s.Remove(i, 1);
            string reverseTemp = reverseText.Remove(s.Length - 1 - i, 1);
            if (temp.Equals(reverseTemp))
                return i;
        }
        return -1;
    }
    public static void Run()
    {
        string s = "abbdda";
        // string s2 = "abca";
        int removeIndex = palindromeIndex(s);
        Console.WriteLine($"Need to remove index {removeIndex} to create palindrome from string '{s}'");
    }
}