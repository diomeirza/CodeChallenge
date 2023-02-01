class JimOrder
{
    /* n = 5
       Customer  = 1 2 3 4 5
       Order     = 8 5 6 2 4
       Prep time = 3 6 2 3 3 
       Delivery  = 11 11 8 5 7
       order by
       delivery  = 5 7 8 11 11
       Customer  = 4 5 3 1 2   // result

       The time of delivery is calculated as the sum of the order number and the preparation time. 
       If two orders are delivered at the same time, assume they are delivered in ascending customer number order
       Return list of customer sorted by delivery
    */
    public static List<int> jimOrders(List<List<int>> orders)
    {
        Dictionary<int,int> dicCustomerServed = new Dictionary<int, int>();
        for (int i=0; i<orders.Count; i++)
        {
            dicCustomerServed.Add(i+1, orders[i].Sum());
        }
        return dicCustomerServed.OrderBy(o => o.Value).Select(x => x.Key).ToList();
    }
    public static void Run()
    {
        List<List<int>> orders = new List<List<int>> { new List<int>{8,3}, 
                                                       new List<int>{5,6}, 
                                                       new List<int>{6,2}, 
                                                       new List<int>{2,3}, 
                                                       new List<int>{4,3}};
        List<int> result = jimOrders(orders);
        Console.WriteLine($"The sorted served customer is {string.Join(",",result)}"); 
    }
}