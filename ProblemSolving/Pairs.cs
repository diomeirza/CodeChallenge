class Pairs
{
    /*
        k = 1
        arr = [1,2,3,4]
        There are three values that differ by 1: [2,1], [3,2], [4,3]. 
        Return 3.
    */
    public static int pairs(int k, List<int> arr)
    {
        int result = 0;
        for (int i=0; i<arr.Count-1; i++)
        {
            if (arr.IndexOf(arr[i] + k,i) >= 0)
                result++;
            if (arr.IndexOf(arr[i] - k,i) >= 0)
                result++;   
        }
        return result;
    }
    public static int pairs_timeout(int k, List<int> arr)
    {
        int result = 0;
        for (int i=0; i<arr.Count-1; i++)
        {
            for (int j=i+1; j<arr.Count; j++)
            {
                int diff = Math.Abs(arr[i] - arr[j]);
                if (diff == k)
                    result++;
            }   
        }
        return result;
    }
    public static void Run()
    {
        int k = 2;
        List<int> arr = new List<int> { 1,5,3,4,2 };
        int result = pairs(k, arr);
        Console.WriteLine($"Number of pair with diff {k} is {result}");
    }
}