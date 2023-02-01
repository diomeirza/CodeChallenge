class BiggerIsGreater
{
    /*
    abcd
    The next largest word is abdc.
    dkhc
    The next largest word is hcdk.
    */
    public string biggerIsGreater(string w)
    {
        if(w.Length < 2)
            return "no answer";

        char[] chars = w.ToArray();

        if(chars.Length == 2)
        {
            int char1 = (int) chars[0];
            int char2 = (int) chars[1];
            if (char2 > char1)
                return $"{chars[1]}{chars[0]}";
            return "no answer";
        }

        int startIndex = GetFirstIndexToModify(chars); 
        if (startIndex == -1)
            return "no answer";

        string leftParts = string.Join("",chars.Take(startIndex));
        char[] rightParts = chars.Skip(startIndex).ToArray();
        int swapPos = rightParts.Select((x,i) => new { Value = x, Index = i})
                                .Where(w => w.Value > rightParts[0])
                                .OrderBy(o => o.Value)
                                .Select(s => s.Index).FirstOrDefault();
        
        if (swapPos<=0)
            return "no answer";
            
        string rightPartResult = string.Empty;
        char temp = rightParts[0];
            rightParts[0] = rightParts[swapPos];
            rightParts[swapPos] = temp;
            char[] orderedRightParts = rightParts.Select(x => x).Skip(1).OrderBy(o => o).ToArray();
            rightPartResult = $"{rightParts[0]}{string.Join("",orderedRightParts)}";
        return $"{leftParts}{rightPartResult}";
    }

    private int GetFirstIndexToModify(char[] chars)
    {
        int index = -1;
        List<int> lookupChar = new List<int>();
        for (int i=chars.Length-1; i>=0; i--)
        {
            int charNo = (int) chars[i];
            if (lookupChar.Any(x => x > charNo))
                return i;              

            lookupChar.Add(charNo);  
        }
        return index;
    }
    
}