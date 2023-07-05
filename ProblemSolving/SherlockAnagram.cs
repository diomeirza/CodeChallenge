class SherlockAnagram
{
    /*
        s = "mom"
        The list of all anagrammatic pairs is [m,m], [mo,om] 
        at positions [0,2], [[0,1], [1,2]]  respectively.
        return 2
    */
    public static int sherlockAndAnagrams(string s)
    {
        int result = 0;
        for (int a = 1; a < s.Length; a++)
        {
            for (int b = 0; b < s.Length - 1; b++)
            {
                if (b+a >= s.Length)
                    continue;

                char[] arrCheckWord = s.Substring(b, a).ToArray();
                Array.Sort(arrCheckWord);
                string checkWord = new string(arrCheckWord);
                for (int c = b+1; c<s.Length; c++)
                {
                    if (c+checkWord.Length > s.Length)
                        continue;

                    char[] arrLookUp = s.Substring(c,checkWord.Length).ToArray();
                    Array.Sort(arrLookUp);
                    string lookUp = new string(arrLookUp);
                    if (checkWord.IndexOf(lookUp) < 0)
                        continue;

                    result++;
                }
            }
        }
        return result;
    }
    public static int sherlockAndAnagrams_Timeout(string s)
    {
        int result = 0;
        for (int a = 1; a < s.Length; a++)
        {
            for (int b = 0; b < s.Length - 1; b++)
            {
                if (b+a >= s.Length)
                    continue;

                string checkWord = s.Substring(b, a);
                checkWord = string.Join("", checkWord.OrderBy(x => x));
                for (int c = b+1; c<s.Length; c++)
                {
                    if (c+checkWord.Length > s.Length)
                        continue;

                    string lookUp = s.Substring(c,checkWord.Length);
                    lookUp = string.Join("", lookUp.OrderBy(x => x));
                    if (!checkWord.Equals(lookUp))
                        continue;

                    result++;
                }
            }
        }
        return result;
    }
    public static void Run()
    {
        string s = "kkkk";
        int result = sherlockAndAnagrams(s);
        Console.WriteLine($"Number of anagrams from '{s}' is {result}");
    }
}