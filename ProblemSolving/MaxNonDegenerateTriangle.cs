class MaxNonDegenerateTriangle
{
    /*
        non degenerate triangle criteria : z < x + y
        Return an array of the lengths of its sides as 3 integers in non-decreasing order
    */
    public static List<int> maximumPerimeterTriangle(List<int> sticks)
    {   
        long totalSides = 0;
        List<int> result = new List<int>{ -1 };
        sticks.Sort();
        for (int i=0; i<sticks.Count-2; i++)
        {
            if (sticks[i+2] >= sticks[i]+ sticks[i+1])
                continue;
            long sumSides = (long) sticks[i] + sticks[i+1] + sticks[i+2];
            if (sumSides > totalSides)
            {
                result = new List<int> { sticks[i],sticks[i+1],sticks[i+2] };
            }
        }
        return result;
    }
    public static void Run()
    {
        List<int> sticks = new List<int> { 1000000000,1000000000,1000000000,1000000000,1000000000,1000000000,1000000000,1000000000,1000000000,1000000000,1000000000,1000000000,1000000000,1000000000,1000000000,1000000000,1000000000,1000000000,1000000000,1000000000,1000000000,1000000000,1000000000,1000000000,1000000000,1000000000,1000000000,1000000000,1000000000,1000000000,1000000000,1000000000,1000000000,1000000000,1000000000,1000000000,1000000000,1000000000,1000000000,1000000000,1000000000,1000000000,1000000000,1000000000,1000000000,1000000000,1000000000,1000000000,1000000000,1000000000 };
        List<int> result = maximumPerimeterTriangle(sticks);
        Console.WriteLine($"Maximum non degenerate triangle from [{string.Join(",",sticks)}] is [{string.Join(",",result)}]");
    }
}