class IceCreamParlor
{
    /* m = 6
       Ice cream cost = [1,3,4,5,6]
       Using 1-based indexing, index 1 & 4 is the highest that they can spent for 2 Ice Creamae
       return 1,4
    */
    public static List<int> icecreamParlor(int m, List<int> arr)
    {
        int highestCost = 0;
        int IndexIce1 = 0;
        int IndexIce2 = 0;
        for (int i=0; i<arr.Count; i++)
        {
            for (int j=i+1; j<arr.Count; j++)
            {
                int currIceCost = arr[i] + arr[j];
                if (currIceCost > highestCost && currIceCost <= m)
                {
                    highestCost = currIceCost;
                    IndexIce1 = i;
                    IndexIce2 = j;
                }
            }
        }
        return new List<int> { IndexIce1+1, IndexIce2+1};
    }

    public static void Run()
    {
        int m = 6;
        List<int> cost = new List<int>{ 1,3,4,5,6};
        List<int> result = icecreamParlor(m,cost);
        Console.WriteLine($"The most they can spent for {m} dollars " +
                          $"from ice cream [{string.Join(",", cost)}] is ice cream {string.Join(",",result)}");
    }
}