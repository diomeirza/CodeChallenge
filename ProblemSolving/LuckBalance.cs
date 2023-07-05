class LuckBalance
{
    /*
        Each contest is described by two integers, L[i] and T[i]:
        L[i] is the amount of luck associated with a contest. 
        If Lena wins the contest, her luck balance will decrease by L[i]; 
        if she loses it, her luck balance will increase by L[i].
        
        T[i] denotes the contest's importance rating. 
        It's equal to 1 if the contest is important, and it's equal to 0 if it's unimportant.
        Find maximum luck if Lena can't lose no more k important contest
    */
    public static int luckBalance(int k, List<List<int>> contests)
    {
        int luck = 0;
        List<int> listOfLuckImportantMatches = new List<int>();
        for (int i=0; i<contests.Count; i++)
        {
            if (contests[i][1] == 0)
                luck += contests[i][0];
            else
                listOfLuckImportantMatches.Add(contests[i][0]);
        }
        listOfLuckImportantMatches.Sort();
        int lastIndex = listOfLuckImportantMatches.Count-1;
        for (int i=0; i<listOfLuckImportantMatches.Count; i++)
        {
            if (i<k)
                luck += listOfLuckImportantMatches[lastIndex-i];
            else
                luck -= listOfLuckImportantMatches[lastIndex-i];
        }   
        return luck;
    }
    public static void Run()
    {
        int k = 3;
        List<List<int>> contests = new List<List<int>> { new List<int> {5,1},
                                                         new List<int> {2,1},
                                                         new List<int> {1,1},
                                                         new List<int> {8,1},
                                                         new List<int> {10,0},
                                                         new List<int> {5,0} };
        int maxLuck = luckBalance(k, contests);
        Console.WriteLine($"Maximum luck is {maxLuck}");
    }
}