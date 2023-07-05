class MinimumDiffAbs
{
    public static int minimumAbsoluteDifference(List<int> arr)
    {
        arr.Sort();
        int min = Math.Abs(arr[0] - arr[1]);
        for (int i = 1; i < arr.Count - 1; i++)
        {
            int absDiff = Math.Abs(arr[i] - arr[i + 1]);
            if (absDiff < min)
                min = absDiff;
        }
        return min;
    }
    public static int minimumAbsoluteDifference_Timeout(List<int> arr)
    {
        int min = Math.Abs(arr[0] - arr[1]);
        for (int i = 0; i < arr.Count - 1; i++)
        {
            for (int j = i + 1; j < arr.Count; j++)
            {
                int absDiff = Math.Abs(arr[i] - arr[j]);
                if (absDiff < min)
                    min = absDiff;
            }
        }
        return min;
    }
    public static void Run()
    {
        List<int> arr = new List<int> { 3, -7, 0 };
        int result = minimumAbsoluteDifference(arr);
        Console.WriteLine($"Minimum absolute difference from [{string.Join(",", arr)}] is {result}");
    }
}