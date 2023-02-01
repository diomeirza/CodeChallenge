class FlipBits
{
    /*
        input = 9
        binary input = 1001, since we want it in 32 bit then
        binary input = 00000000000000000000000000001001
        flip bits    = 11111111111111111111111111110110
        int flip bits = 4294967286
    */
    public static long flippingBits(long n)
    {
        string binary = Convert.ToString(n,2);
        binary = binary.PadLeft(32,'0');
        long result = 0;
        for(int i=0; i<binary.Length; i++)
        {
            if(binary[i].Equals('0'))
                result += (long) Math.Pow(2,binary.Length-1-i); 
        }
        return result;
    }
    public static void Run()
    {
        long n = 9;
        long result = flippingBits(n);
        Console.WriteLine($"flipping bits from {n} is {result}");
    }
}