class Pangrams
{
    public static string pangrams(string s)
    {
        char[] chars = s.Replace(" ","").ToLower().ToArray();
        int[] arrAplhabet = new int[26];
        int numericA = (int) 'a';
        for (int i=0; i<chars.Length; i++)
        {
            int numericLetter = (int) chars[i];
            arrAplhabet[numericLetter - numericA] += 1;
        }
        return (arrAplhabet.Any(x => x == 0)) ? "not pangram" : "pangram";
    }
}