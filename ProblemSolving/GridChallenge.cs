class GridChallenge
{
    /*
        Given a square grid of characters in the range ascii[a-z], 
        rearrange elements of each row alphabetically, ascending. 
        Determine if the columns are also in ascending alphabetical order, top to bottom. 
        Return YES if they are or NO if they are not.
    */
    public static string gridChallenge(List<string> grid)
    {
        char[] prevChars = grid[0].OrderBy(x => x).ToArray();
        for (int i=1; i<grid.Count; i++)
        {   
            char[] currChars = grid[i].OrderBy(x => x).ToArray();
            for (int j=0; j<prevChars.Length; j++)
            {
                if (currChars[j] < prevChars[j])
                    return "NO";
            }
            prevChars = currChars;
        }
        return "YES";
    }
    public static void Run()
    {
        List<string> grid = new List<string>{ "abc","ade", "efg" };
        string result = gridChallenge(grid);
        Console.WriteLine($"can the grid rearranged so the column is ascending: {result}");
    }
}