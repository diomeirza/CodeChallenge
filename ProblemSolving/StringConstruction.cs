class StringConstruction
{
    /*
        Amanda has a string of lowercase letters that she wants to copy to a new string. 
        She can perform the following operations with the given costs. 
        She can perform them any number of times to construct a new string p:
        -   Append a character to the end of string p at a cost of 1 dollar.
        -   Choose any substring of p and append it to the end of p at no charge.
        Given n strings s[i], find and print the minimum cost of copying each s[i] to p[i] on a new line
        s = abcabc
        1. append char a
        2. append char b
        3. append char c
        4. append char abc
    */
    public static int stringConstruction(string s)
    {
        return s.Distinct().Count();
    }
    public static void Run()
    {
        string s = "acca";
        int result = stringConstruction(s);
        Console.WriteLine($"Minimum cost to copy string {s} is {result}");
    }
}