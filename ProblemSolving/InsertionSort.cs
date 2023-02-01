class InsertionSort
{
    /* n =5
       arr = [2,4,6,8,3]
       output :
       2 4 6 8 8
       2 4 6 6 8
       2 4 4 6 8
       2 3 4 6 8
    */
    public static void insertionSort1(int n, List<int> arr)
    {
        int lastIndex = n - 1;
        int lastItem = arr[lastIndex];
        for (int i = lastIndex; i >= 0; i--)
        {
            if (i == 0)
                arr[i] = lastItem;
            else if (arr[i - 1] > lastItem)
            {
                arr[i] = arr[i - 1];
            }
            else
            {
                arr[i] = lastItem;
                i = -1;
            }
            Console.WriteLine(string.Join(" ", arr));
        }
    }

    public static void Test()
    {
        int n = 5;
        // int n = 10;
        List<int> arr = new List<int> { 2, 4, 6, 8, 3 };
        // List<int> arr = new List<int> { 2,3,4,5,6,7,8,9,10,1};
        insertionSort1(n, arr);
    }

    public static void insertionSortInvariant(int[] A)
    {
        for (int i = 1; i < A.Length; i++)
        {
            for (int j = i; j > 0; j--)
            {
                if (A[j] < A[j - 1])
                {
                    int temp = A[j - 1];
                    A[j - 1] = A[j];
                    A[j] = temp;
                }
            }
        }
        Console.WriteLine(string.Join(" ", A));
    }
    public static void RunInvariant()
    {
        int[] arr = new int[] { 4, 1, 3, 5, 6, 2 };
        insertionSortInvariant(arr);
    }

    public static void insertionSort2(int n, List<int> arr)
    {
        for (int j = 1; j < arr.Count; j++)
        {
            int currItem = arr[j];
            for (int i = j; i >= 0; i--)
            {
                if (i == 0)
                    arr[i] = currItem;
                else if (arr[i - 1] > currItem)
                {
                    arr[i] = arr[i - 1];
                }
                else
                {
                    arr[i] = currItem;
                    i = -1;
                }
            }
            Console.WriteLine(string.Join(" ", arr));
        }
    }

    public static void RunInsertionSort2()
    {
        int n = 7;
        List<int> arr = new List<int> { 3,4,7,5,6,2,1 };
        insertionSort2(n, arr);
    }
}