class MiniMaxSum
{
    public static void miniMaxSum(List<int> arr)
    {
        arr.Sort();
        long sumMin = arr.Take(4).Select(x => (long) x).Sum();
        long sumMax = arr.Skip(1).Select(x => (long) x).Sum();
        Console.WriteLine($"{sumMin} {sumMax}");
    }

    public static void CountMiniMax()
    {
        int maxNum = (int) Math.Pow(10,9);
        List<int> arr = new List<int> {maxNum-5, maxNum-4, maxNum-3, maxNum-2, maxNum-1};
        miniMaxSum(arr);
    }

}