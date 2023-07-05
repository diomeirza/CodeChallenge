using System.Text;

class SplitStringBuilderToMultipleOR
{
    private static List<List<T>> ChunkList<T>(IEnumerable<T> data, int size)
    {
        return data
          .Select((x, i) => new { Index = i, Value = x })
          .GroupBy(x => x.Index / size)
          .Select(x => x.Select(v => v.Value).ToList())
          .ToList();
    }
    private static StringBuilder SplitWhereClauseToMultipleOR(List<string> positionList)
    {
        StringBuilder positionsSelect = new StringBuilder(" where");
        int oracleLimitExp = 2;
        List<List<string>> positionChunks = ChunkList(positionList, oracleLimitExp);

        for (int i = 0; i < positionChunks.Count; i++)
        {
            StringBuilder tempValues;
            if (i == 0)
                tempValues = new StringBuilder(" fee.dbvalue in (");
            else
                tempValues = new StringBuilder(" OR fee.dbvalue in (");

            foreach (string position in positionChunks[i])
            {
                tempValues.AppendFormat("{0},", position);
            }
            tempValues.Remove(tempValues.Length - 1, 1);
            tempValues.Append(")");
            positionsSelect.Append(tempValues);
        }
        return positionsSelect;
    }

    public static void Test()
    {
        List<string> position = new List<string> { "1","2","3","4","5","6","7","8","9","10" };
        StringBuilder result = SplitWhereClauseToMultipleOR(position);
        Console.WriteLine(result);
    }
}