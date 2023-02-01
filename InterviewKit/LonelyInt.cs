class LonelyInt
{
    public static int lonelyinteger(List<int> a)
    {
        return a.GroupBy(g => g)
                .Select(s => new {Value = s.Key, Cnt = s.Count()})
                .Where( w => w.Cnt == 1)
                .Select(x => x.Value).First();
    }
}