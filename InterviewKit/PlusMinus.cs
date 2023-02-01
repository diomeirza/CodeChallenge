class PlusMinus
{
    /*  arr = [1,1,0,-1,-1]
        There are  elements, two positive, two negative and one zero. 
        Their ratios are 2/5 positives = 0.4, 
        2/5 negatives = 0.4,
        and 1/5 zero = 0.2. Results are printed as:
        0.400000
        0.400000
        0.200000
    */
    public static void plusMinus(List<int> arr)
    {
        int[] arrCount = new int[3];
        int len = arr.Count;
        foreach(int item in arr)
        {
            if (item > 0)
                arrCount[0]+=1;
            else if (item < 0)
                arrCount[1]+=1;
            else
                arrCount[2]+=1;
        }
        foreach(int item in arrCount)
        {
            double ratio = (double) item/len;
            Console.WriteLine(ratio.ToString("0.000000"));
        }
    }

    public static void CountPlusMinus()
    {
        List<int> lst = new List<int> {1,1,0,-1,-1};
        plusMinus(lst);
    }
}