class ZigZagSequence
{
    static List<int> findZigZagSequence(List<int> a)
    {
        int maxNo = a.Max();
        List<int> temp = a;
        a.Sort();
        List<int> sortDesc = temp.OrderByDescending(x => x).ToList();
        List<int> result = new List<int>();
        result.AddRange(a.Take(a.Count/2).ToList());
        result.Add(maxNo);
        result.AddRange(sortDesc.Skip(1).Take(a.Count/2).ToList());
        return result;
    }
}