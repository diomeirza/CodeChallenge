class CountingSort
{
    /*  arr = [1,1,3,2,1] 
        The frequency array is [0,3,1,1]
        index 0 = 0 times
        index 1 = 3 times
        index 2 = 1 times
        index 1 = 1 times
    */
    public static List<int> countingSort(List<int> arr)
    {
        int [] arrResult = new int[100];
        for(int i=0; i<arr.Count; i++)
        {
            arrResult[arr[i]] = arrResult[arr[i]] + 1;     
        }
        return arrResult.ToList();
    }

    public static List<int> countingSort2(List<int> arr)
    {
        List<int> countArray = countingSort(arr);
        List<int> result = new List<int>();
        for (int i=0; i< countArray.Count; i++)
        {
            if (countArray[i] == 0)
                continue;
            for (int j=0; j<countArray[i]; j++)
            {
                result.Add(i);
            }
        }
        return result;
    }
}