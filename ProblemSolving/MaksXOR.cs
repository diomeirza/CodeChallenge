class MaksXOR
{
    public static int maximizingXor(int l, int r)
    {
        int maksXOR = 0;
        for(int i=l; i<r; i++)
        {
            for(int j=i+1; j<=r; j++)
            {
                string bits1 = Convert.ToString(i,2);
                string bits2 = Convert.ToString(j,2);
                int valXOR = XOR(bits1,bits2);
                if (valXOR > maksXOR)
                    maksXOR = valXOR;
            }
        }
        return maksXOR;
    }

    public static int XOR(string bits1, string bits2)
    {
        if (bits1.Length > bits2.Length)
            bits2 = bits2.PadLeft(bits1.Length,'0');
        else
            bits1 = bits1.PadLeft(bits2.Length,'0');
        
        int resultXOR = 0;
        for (int i=0; i<bits1.Length; i++)
        {
            if(bits1[i] != bits2[i])
                resultXOR += (int) Math.Pow(2,bits1.Length-1-i);
        }
        return resultXOR;
    }

    public static void Run()
    {
        int l = 11;
        int r = 100;
        int result = maximizingXor(l,r);
        Console.WriteLine($"Maximum XOR value from {l} to {r} is {result}");
    }
}