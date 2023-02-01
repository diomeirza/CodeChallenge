class SumXOR
{
    public static long sumXor(long n)
    {
        if (n == 0)
            return 1;
        string bitN = Convert.ToString(n,2);
        long countZeroBits = bitN.Where(x => x.Equals('0')).Count();
        return (long) Math.Pow(2, countZeroBits);
    }
    public static long sumXor_Timeout(long n)
    {
        long result = 0;
        for(long i=0; i<=n; i++)
        {
            if (n+i == (n | i))
                result++;
        }
        return result;
    }
    public static void Run()
    {
        long n = 1;
        long result = sumXor(n);
        Console.WriteLine($"Total count Sum XOR of {n} is {result}");
    }
}