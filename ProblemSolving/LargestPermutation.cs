class LargestPermutation
{
    /*
        arr = [1,2,3,4]
        k = 1
        The following arrays can be formed by swapping the  with the other elements:
        [2,1,3,4]
        [3,2,1,4]
        [4,2,3,1]
        Return array [4,2,3,1] as it is the largest number
    */
    public static List<int> largestPermutation(int k, List<int> arr)
    {
        List<int> result = new List<int>(arr);
        List<int> descOrder = arr.OrderByDescending(x => x).ToList();
        int countSwap = 0;
        int indeksMaxVal = 0;
        for (int i=0; i<arr.Count; i++)
        {
            if (countSwap == k)
                return result;
            if (result[i] >= descOrder[indeksMaxVal])
            {
                indeksMaxVal++;
            }
            else 
            {
                int temp = result[i];
                int tempIndex = result.IndexOf(descOrder[indeksMaxVal]);
                result[i] = descOrder[indeksMaxVal];
                result[tempIndex] = temp;
                indeksMaxVal++;
                countSwap++;
            }
        }
        return result;
    }
    public static void Run()
    {
        int k = 2;
        List<int> arr = new List<int> { 6,3,5,4,2 };
        List<int> result = largestPermutation(k, arr);
        Console.WriteLine($"Largest permutaition from [{string.Join(",", arr)}] is [{string.Join(",", result)}]");
    }
}