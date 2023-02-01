class MissingNumbers
{
    public static List<int> missingNumbers(List<int> arr, List<int> brr)
    {
        Dictionary<int,int> arrDic = arr.GroupBy(x => x)
                                        .Select(s => new { Value = s.Key, Count = s.Count()})
                                        .ToDictionary(item => item.Value, item => item.Count);

        Dictionary<int,int> brrDic = brr.GroupBy(x => x)
                                        .Select(s => new { Value = s.Key, Count = s.Count()})
                                        .ToDictionary(item => item.Value, item => item.Count);
        List<int> result = brrDic.Where(x => !arrDic.ContainsKey(x.Key) ||
                                             arrDic[x.Key] != x.Value)
                                 .Select(s => s.Key).ToList();
        result.Sort();
        return result;
    }

    public static void Run()
    {
        List<int> arr = new List<int> {7,2,5,3,5,3};
        List<int> brr = new List<int> {7,2,5,4,6,3,5,3};
        //Result = 4,6
        List<int> result = missingNumbers(arr,brr);
        Console.WriteLine($"Missing munmbers is {string.Join(" ", result)}");
    }
}