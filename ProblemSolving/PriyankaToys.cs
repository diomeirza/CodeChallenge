class PriyankaToys
{
    /*
        there are items with weights w = [1,2,3,4,5,10,11,12,13]. 
        This can be broken into two containers: [1,2,3,4,5] and [10,11,12,13]. 
        Each container will contain items weighing within 4 units + the minimum weight item
        container 1 contain item with weight 4+1 = 5
        container 2 contain item with weight 4+10 = 14
    */
    public static int toys(List<int> w)
    {
        w.Sort();
        int minWeightInContainer = w[0];
        int countCountainer = 1;
        foreach(int item in w)
        {
            if (item > minWeightInContainer+4)
            {
                countCountainer++;
                minWeightInContainer = item;
            }                   
        }   
        return countCountainer;
    }
    public static void Run()
    {
        // List<int> w = new List<int> { 1,2,3,4,5,10,11,12,13 };
        List<int> w = new List<int> { 1,2,3,21,7,12,14,21 };
        int result = toys(w);
        Console.WriteLine($"Items [{string.Join(",",w)}] can be shipped using {result} containers");
    }
}