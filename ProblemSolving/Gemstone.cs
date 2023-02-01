class Gemstone
{
    /*
    arr = ["abc","bc","bc"]
    The minerals b and c appear in each rock, so there are 2 gemstones.
    */
    public static int gemstones(List<string> arr)
    {   
        Dictionary<char,List<int>> dic = new Dictionary<char, List<int>>();
        int gemstone = 0;
        for (int i=0; i<arr.Count; i++)
        {
            char[] chars = arr[i].ToArray();
            foreach(char item in chars)
            {
                
                if(dic.ContainsKey(item))
                {
                    if (dic[item].Contains(i))
                        continue;
                    dic[item].Add(i);
                }
                else
                {
                    dic.Add(item, new List<int> {i});
                }

                if(dic[item].Count == arr.Count)
                    gemstone +=1;
            }
        }
        return gemstone;
    }

    public static void CountGemstones()
    {
        List<string> arr = new List<string> { "abc", "abc", "bc"};
        int countGemstones = gemstones(arr);
        Console.WriteLine($"string {string.Join(",",arr)} has {countGemstones} gemstones");
    }
}