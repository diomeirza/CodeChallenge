class LarryArray
{
    /*
        Larry has been given a permutation of a sequence of natural numbers incrementing from 1 as an array. 
        He must determine whether the array can be sorted using the following operation any number of times:

        Choose any 3 consecutive indices and rotate their elements in such a way that
        ABC -> BCA -> CAB -> ABC
        Example A = {1,6,5,2,4,3}
        A                   Rotate
        {1,6,5,2,4,3}       [6,5,2]
        {1,5,2,6,4,3}       [5,2,6]
        {1,2,6,5,4,3}       [5,4,3]
        {1,2,6,3,5,4}       [6,3,5]
        {1,2,3,5,6,4}       [5,6,4]
        {1,2,3,4,5,6}       
        Return YES otherwise NO
    */
    public static string larrysArray(List<int> A)
    {
        // 1 2 3 5 4
        int countInversion = 0;
        for (int i=0; i<A.Count; i++)
        {
            int countLeftSideIsBigger = A.GetRange(0,i+1).Where(x => x > A[i]).Count();
            countInversion += countLeftSideIsBigger;
        }
        if (countInversion % 2 == 0)
            return "YES";
        return "NO";
    }
    
    public static void Run()
    {
        List<int> A = new List<int> {1,2,3,5,4};
        string result = larrysArray(A);
        Console.WriteLine($"Array [{string.Join(",",A)}] can be sorted : {result}");
    }
}