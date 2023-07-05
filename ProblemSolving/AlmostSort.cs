class AlmostSort
{
    /*
        Given an array of integers, determine whether the array can be sorted in ascending order 
        using only one of the following operations one time.
        1. Swap two elements.
        2. Reverse one sub-segment.
        
        If the array is already sorted, output yes on the first line. You do not need to output anything else.
        If you can sort this array using one single operation (from the two permitted operations) then output yes on the first line 
        and then print the index element (for swap print the first and last index element):
    */
    public static void almostSorted(List<int> arr)
    {
        List<int> sortedArr = new List<int>(arr);
        List<int> temp = new List<int>();
        List<int> indexTemp = new List<int>();

        sortedArr.Sort();

        if (arr == sortedArr)
            Console.WriteLine("yes");
        
        for (int i=0; i<arr.Count; i++)
        {
            if (arr[i] == sortedArr[i])
                continue;
            temp.Add(arr[i]);
            indexTemp.Add(i+1);
        }
        if (temp.Count == 0)
        {
            Console.WriteLine("yes");
        }
        else if (temp.Count == 2)
        {
            Console.WriteLine("yes");
            Console.WriteLine($"swap {indexTemp[0]} {indexTemp[1]}");
        }
        else if (temp.Count > 2)
        {
            List<int> reverseTemp = new List<int>(temp);
            reverseTemp.Reverse();
            temp.Sort();
            if (!temp.SequenceEqual(reverseTemp))
            {
                Console.WriteLine("no");
                return;
            }
            Console.WriteLine("yes");
            Console.WriteLine($"reverse {indexTemp[0]} {indexTemp[indexTemp.Count-1]}");
            
        }
        else
        {
            Console.WriteLine("no");
        }
    }
    public static void Run()
    {
        List<int> arr = new List<int> { 1,5,4,3,2,6};
        almostSorted(arr);
    }
}