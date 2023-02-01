class MakingAnagram
{
    /*
        s1 = abc
        s2 = amnop
        The only characters that match are the a's so we have to remove bc from s1 and mnop from s2 
        for a total of 6 deletions.
    */
    public static int makingAnagrams(string s1, string s2)
    {
        Dictionary<char,int> dicS1 = s1.GroupBy(x => x).ToDictionary(d => d.Key, x=> x.Count());
        Dictionary<char,int> dicS2 = s2.GroupBy(x => x).ToDictionary(d => d.Key, x=> x.Count());
        int deleteS1 = dicS1.Where(x => !dicS2.ContainsKey(x.Key)).Select(x => x.Value).Sum();
        int deleteS2 = dicS2.Where(x => !dicS1.ContainsKey(x.Key)).Select(x => x.Value).Sum();
        int deleteDuplicateS1 = dicS1.Where(x => dicS2.ContainsKey(x.Key) && x.Value > dicS2[x.Key])
                                     .Select(s => s.Value - dicS2[s.Key]).Sum();
        int deleteDuplicateS2 = dicS2.Where(x => dicS1.ContainsKey(x.Key) && x.Value > dicS1[x.Key])
                                     .Select(s => s.Value - dicS1[s.Key]).Sum();
        return deleteS1 + deleteS2 + deleteDuplicateS1 + deleteDuplicateS2;
    }
    public static void Run()
    {
        string s1 = "absdjkvuahdakejfnfauhdsaavasdlkj";
        string s2 = "djfladfhiawasdkjvalskufhafablsdkashlahdfa";
        int result = makingAnagrams(s1,s2);
        Console.WriteLine($"Need to delete {result} characters to make anagram from {s1} and {s2}");
    }

    /*
        string s = aaabbb
        We split s into two strings ='aaa' and ='bbb'. 
        We have to replace all three characters from the first string with 'b' to make the strings anagrams.
        return 3
    */
    public static int anagram(string s)
    {   
        if (s.Length % 2 == 1)
            return -1;
        
        string firstString = s.Substring(0,s.Length/2);
        string secondString = s.Substring(s.Length/2);
        Dictionary<char,int> dicS1 = firstString.GroupBy(x => x).ToDictionary(d => d.Key, x=> x.Count());
        Dictionary<char,int> dicS2 = secondString.GroupBy(x => x).ToDictionary(d => d.Key, x=> x.Count());
        int deleteS1 = dicS1.Where(x => !dicS2.ContainsKey(x.Key)).Select(x => x.Value).Sum();
        int deleteDuplicateS1 = dicS1.Where(x => dicS2.ContainsKey(x.Key) && x.Value > dicS2[x.Key])
                                     .Select(s => s.Value - dicS2[s.Key]).Sum();

        return deleteS1 + deleteDuplicateS1;
    }
    public static void RunAnagram()
    {
        string s = "aaabbb";
        int result = anagram(s);
        Console.WriteLine($"Need to replace {result} characters to create anagram from {s.Substring(0,s.Length/2)} to {s.Substring(s.Length/2)}.");
    }
}