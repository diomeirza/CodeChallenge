class QuickSort
{
    public static List<int> quickSort(List<int> arr)
    {
        int p = arr[0];
        List<int> left = arr.Where(x => x < p).ToList();
        List<int> right = arr.Where(x => x > p).ToList();
        List<int> result = new List<int>();
        result.AddRange(left);
        result.Add(p);
        result.AddRange(right);
        return result; 
    }
    public static void Run()
    {
        List<int> arr = new List<int> { 5,7,4,3,8 };
        List<int> result = quickSort(arr);
        Console.WriteLine($"Quick Partition sort from [{string.Join(",",arr)}] is [{string.Join(",",result)}]");
    }
}