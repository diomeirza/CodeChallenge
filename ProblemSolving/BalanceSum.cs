class BalanceSum
{
    /*
        r = [1,1,4,1,1]
        Output = YES
        Because there is an element which sum of the left side is equal with sum of the right side
        in this case, element "4" is between sum of the left side = 2 and sum of the right side = 2
        So, return yes otherwise return no
    */
    public static string balancedSums(List<int> arr)
    {
        int leftSide = 0;
        int rightSide = arr.Sum();
        for (int i=0; i<arr.Count; i++)
        {
            rightSide -= arr[i];
            if (leftSide == rightSide)
                return "YES";
            leftSide += arr[i];
            
        }
        return "NO";
    }

    public static void Run()
    {
        List<int> arr = new List<int> { 1,1,4,1,1};
        string result = balancedSums(arr);
        Console.WriteLine($"Is there balance element in the array of" + 
                          $"{string.Join(" ",arr)}? The answer is {result}");
        
    }
}