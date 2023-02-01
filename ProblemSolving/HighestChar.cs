using System.Text.RegularExpressions;

public static class HighestChar
{
    public static void CountHighestChar(string sentence)
    {
        Regex rx = new Regex(@"^[a-zA-Z0-9]+\z");
        if (!rx.Match(sentence).Success)
        {
            Console.WriteLine("sentence is not valid");
            return;
        }
        char[] arrSentence = sentence.ToArray();
        int highestCount = 0;
        char highestChar = '\0';
        foreach (var i in arrSentence.Distinct())
        {
            int count = arrSentence.Where(x => x == i).Count();
            if (count > highestCount)
            {
                highestCount = count;
                highestChar = i;
            }
        }
        Console.WriteLine($"most used char is {highestChar}. It is used {highestCount} times");
    }
}