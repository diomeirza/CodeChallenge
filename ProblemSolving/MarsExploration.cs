class MarsExploration
{
    /*
    Expected signal: SOSSOSSOSSOS
    Recieved signal: SOSSPSSQSSOR
    Difference:          X  X   X
    return 3
    */
    public static int marsExploration(string s)
    {
        int result = 0;
        for (int i=0; i<s.Length; i+=3)
        {
            string signal = s.Substring(i,3);
            if(signal[0] != 'S')
                result++;
            if(signal[1] != 'O')
                result++;
            if(signal[2] != 'S')
                result++;
        }
        return result;
    }
    public static void Run()
    {   
        string s = "SOSSPSSQSSOR";
        int result = marsExploration(s);
        Console.WriteLine($"Number of altered characters from '{s}' is {result}");
    }   
}