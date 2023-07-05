class CaesarCipher
{
    /*
        Original alphabet:      abcdefghijklmnopqrstuvwxyz
        Alphabet rotated +3:    defghijklmnopqrstuvwxyzabc  
    */
    public static string caesarCipher(string s, int k)
    {
        string result = string.Empty;
        string alphabets = "abcdefghijklmnopqrstuvwxyz";
        string upperAlphabets = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        for (int i=0; i<s.Length; i++)
        {
            int alphabet = alphabets.IndexOf(s[i]);
            int upperAlphabet = upperAlphabets.IndexOf(s[i]);
            if (alphabet >= 0)
            {
                int tes = (alphabet + k) % alphabets.Length;
                result = string.Concat(result,alphabets[(alphabet + k) % alphabets.Length]);
            }
            else if (upperAlphabet >= 0)
                result = string.Concat(result,upperAlphabets[(upperAlphabet + k) % upperAlphabets.Length]);
            else
                result = string.Concat(result,s[i]);
        }
        return result;
    }
    public static void Run()
    {
        string s = "middle-Outz";
        int k = 2;
        string result = caesarCipher(s, k);
        Console.WriteLine($"The result of moving {k} chars from '{s}' is {result}");
    }
}