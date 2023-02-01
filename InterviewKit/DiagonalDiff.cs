class DiagonalDiff
{
    public static int diagonalDifference(List<List<int>> arr)
    {
        int len = arr.Count;
        int diagonal0 = 0;
        int diagonal1 = 0;
        for (int i=0; i<len; i++)
        {
            diagonal0 = diagonal0 + arr[i][i];
            diagonal1 = diagonal1 + arr[i][len-i-1];
        }
        return Math.Abs(diagonal0-diagonal1);
    }
}