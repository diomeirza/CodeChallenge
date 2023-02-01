class ClosestNumbers
{
    /*
        arr = [5,2,3,4,1]
        sorted arr = [1,2,3,4,5]
        several pairs have the minimum difference of 1 :
        [(1,2),(2,3),(3,4),(4,5)]
        return array = [1,2,2,3,3,4,4,5]
    */
    public static List<int> closestNumbers(List<int> arr)
    {
        Dictionary<int,List<int>> result = new Dictionary<int, List<int>>();
        arr.Sort();
        for(int i=0; i<arr.Count-1; i++)
        {
            int difference = Math.Abs(arr[i] - arr[i+1]);
            if (result.ContainsKey(difference))
            {
                result[difference].Add(arr[i]);
                result[difference].Add(arr[i+1]);
            }
            else
            {
                result.Add(difference, new List<int> { arr[i], arr[i+1]});
            }
        }

        return result.MinBy(x => x.Key).Value;
    }
    public static void Run()
    {
        List<int> arr = new List<int> { 5,2,3,4,1};
        List<int> result = closestNumbers(arr);
        Console.WriteLine($"The min different array of [{string.Join(",",arr)}] is [{string.Join(",",result)}]");
    }
}