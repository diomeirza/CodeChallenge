class ManasaStone
{
    /*  n = 3
        a = 1
        b = 2
        With differences 1 and 2, all possible series for the first test case are given below:
        0,1,2
        0,1,3
        0,2,3
        0,2,4
        Hence the answer is 2,3,4
    */
    public static List<int> stones(int n, int a, int b)
    {
        List<int> result = new List<int>{0};
        for (int i=1; i<n; i++)
        {
            List<int> temp = new List<int>();
            foreach(int item in result)
            {
                int nextStoneA = item + a;
                int nextStoneB = item + b;
                if (!temp.Contains(nextStoneA))
                    temp.Add(nextStoneA);
                if (!temp.Contains(nextStoneB))
                    temp.Add(nextStoneB);
            }
            result = temp;
        }
        return result.OrderBy(x => x).ToList();
    }

    public static void CountManasaStone()
    {
        int n = 4;
        int a = 10;
        int b = 100;
        List<int> cnt = stones(n,a,b);
        Console.WriteLine($"Manasa stone from n={n},a={a},b={b} is {string.Join(" ",cnt)}");
    }
}