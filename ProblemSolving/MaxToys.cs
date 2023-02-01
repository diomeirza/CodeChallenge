class MaxToys
{
    /*
        prices = [1,2,3,4]
        k = 7
        The budget is 7 units of currency. He can buy items that cost [1,2,3] for 6, or [3,4] for 7 units. 
        The maximum is 3 items.
    */
    public static int maximumToys(List<int> prices, int k)
    {
        prices.Sort();
        int itemBought = 0;
        foreach (int item in prices)
        {
            if (k > item)
            {
                k -= item;
                itemBought++;
            }
            else
            {
                return itemBought;
            }
        }
        return itemBought;
    }
    public static void Run()
    {
        List<int> prices = new List<int> {1,2,3,4};
        int k = 7;
        int result = maximumToys(prices, k);
        Console.WriteLine($"maximum toys that can be bought is {result}");
    }
}