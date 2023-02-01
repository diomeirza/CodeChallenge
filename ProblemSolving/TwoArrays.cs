class TwoArrays
{
     /* a = { 2,1,3 };
        b = { 7,8,9 };
        Result = Yes, because
        a can be modified to 1,2,3. 
        a[0] + b[0] >= 10
        a[1] + b[1] >= 10
        a[2] + b[2] >= 10
        */
    public static string twoArrays(int k, List<int> A, List<int> B)
    {
        for (int i=0; i<A.Count; i++)
        {
            int requiredNum = k-A[i];
            bool isOtherArrayHasIt = B.Where(x => x >= requiredNum).Any();
            if ( isOtherArrayHasIt)
            {
                int b = B.Where(x => x >= requiredNum).Min();
                B.Remove(b);
            }
            else
            {
                return "NO";
            }
        }
        return "YES";   
    }
    public static void Run()
    {
        // int k = 10;
        // List<int> a = new List<int>{ 2,1,3 };
        // List<int> b = new List<int>{ 7,8,9 };
        int k = 5;
        List<int> a = new List<int>{ 1,2,2,1 };
        List<int> b = new List<int>{ 3,3,3,4 };
        string result = twoArrays(k, a, b);
        Console.WriteLine($"{result}, sum of each element two arrays is >= {k}");
    }
}