//O(n)
//O(n)

using System.Collections;

public class Solution
{
    public bool UniqueOccurrences(int[] arr)
    {
        var countDict = new Dictionary<int, int>();

        foreach (int num in arr)
        {
            if (countDict.ContainsKey(num))
            {
                countDict[num]++;
            }
            else
            {
                countDict[num] = 1;
            }
        }

        var occurrenceSet = new HashSet<int>(countDict.Values);

        return countDict.Count == occurrenceSet.Count;
    }
}
