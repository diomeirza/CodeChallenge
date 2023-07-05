class WeightStrings
{
    /*
        s = "abbcccdddd"
        queries = [1,7,5,4,15]
        string  weight
        a       1
        b       2
        bb      4
        c       3
        cc      6
        ccc     9
        d       4
        dd      8
        ddd     12
        dddd    16
        Now for each value in queries, 
        see if it exists in the possible string weights. The return array is ['Yes', 'No', 'No', 'Yes', 'No'].
    */
    public static List<string> weightedUniformStrings_timeout(string s, List<int> queries)
    {
        string alphabets = string.Join("",s.Distinct());
        int ascii_a = (int) 'a';
        List<string> result = new List<string>();
        foreach(int item in queries)
        {
            bool isUniformStringExists = false;
            for (int i=0; i<alphabets.Length; i++ )
            {
                int currAscii = (int) alphabets[i] - ascii_a + 1;
                if (item % currAscii != 0)
                    continue;
                int countChar = item/currAscii;
                string uniformStr = string.Empty.PadLeft(countChar,alphabets[i]);
                if (s.IndexOf(uniformStr) < 0)
                    continue;
                result.Add("Yes");
                isUniformStringExists = true;
                break;
            }
            if (!isUniformStringExists)
                result.Add("No");
        }
        return result;
    }
    public static List<string> weightedUniformStrings(string s, List<int> queries)
    {
        string alphabet = "abcdefghijklmnopqrstuvwxyz";
        int weight = 0;
        List<int> weights = new List<int>();
        char last = s[0];
        for(int i = 0; i < s.Length; i++){            
            char cur = s[i];
            if(i == 0 || cur != last){
                weight = (alphabet.IndexOf(cur) + 1);
            } else {
                weight += (alphabet.IndexOf(cur) + 1);                
            }             
            weights.Add(weight);
            last = cur;
        }        
        List<string> result = new List<string>();
        for(int i = 0; i < queries.Count; i++){
            if(weights.Contains(queries[i])) result.Add("Yes");
            else result.Add("No");
        }        
        return result;
    }
    public static void Run()
    {
        string s = "abbcccdddd";
        List<int> queries = new List<int> { 1, 7, 5, 4, 15 };
        List<string> result = weightedUniformStrings(s, queries);
        Console.WriteLine($"String '{s}' with queries [{string.Join(",", queries)}] is uniform weight [{string.Join(",", result)}]");
    }
}