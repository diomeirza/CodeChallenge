class MoveZero
{
    public static void MoveZeroes(int[] nums) {
        List<int> zeroes = new List<int>();
        List<int> nonZeroes = new List<int>();
        foreach(int num in nums)
        {
            if (num == 0)
                zeroes.Add(num);
            else
                nonZeroes.Add(num);
        }
        nonZeroes.AddRange(zeroes);
        Array.Copy(nonZeroes.ToArray(),nums,nums.Length);
    }

    public static void Run()
    {
        int[] nums = new int[] { 0,1,0,3,12 };
        MoveZeroes(nums);
        Console.WriteLine($"Movezero is {string.Join(",",nums)}");
    }
}