class TuringTest
{
    // input = ab-cd
    // output = dc-ba
    // input 2 = ab-cd?/
    // output 2 = dc-ba?/
    public string ReverseOnlyLetters(string s)
    {
        int A = (int) 'A';
        int Z = (int) 'A';
        int a = (int) 'a';
        int z = (int) 'z';
        char[] arrChar = s.ToArray();
        char[] reverse = new char[arrChar.Length];
        Dictionary<char, int> dicLetterNeedReverse = new Dictionary<char, int>();
        for (int i=0; i< arrChar.Length; i++)
        {
            int ascii = (int) arrChar[i];
            bool isLetter = (ascii >= a && ascii <= z) || (ascii >= A && ascii <= Z);
            if (!isLetter)
            {
                reverse[i] = arrChar[i];
            } 
            else
            {
                dicLetterNeedReverse.Add(arrChar[i],i);
            }
        }
        int len = dicLetterNeedReverse.Count();
        for (int j=0; j<len; j++)
        {
            int reversePosition = dicLetterNeedReverse.ElementAt(len-1-j).Value;
            char letter = dicLetterNeedReverse.ElementAt(j).Key;
            reverse[reversePosition] = letter;
        }
        return string.Join("", reverse);
    }

    // input = 2,2,3,4
    // output = 2
    // input 2= 1,2,2,3,3,3
    // output 2= 3
    // input 3 = 2,2,2,3,3
    // output 3 = -1
    public int FindLuckyNumber(int[] arr)
    {
        int luckyNumber = -1;
        Dictionary<int, int> dicCountNumber = new Dictionary<int, int>();
        for(int i=0; i<arr.Length; i++)
        {
            int number = arr[i];
            if (!dicCountNumber.ContainsKey(number))
            {
                dicCountNumber.Add(number, 1);    
            }
            else
            {
                dicCountNumber[number] += 1;
            }
        }
        foreach(var item in dicCountNumber)
        {
            if(item.Key == item.Value && item.Value > luckyNumber)  
                luckyNumber = item.Value;
        }
        return luckyNumber;

        
    }

    

}