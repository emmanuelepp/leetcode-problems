//O(n)
//O(n)
public class Solution
{
    public int CountElements(int[] arr)
    {
        if (arr.Length == 0) return -1;

        var set = new HashSet<int>(arr);
        var count = 0;

        foreach (var num in arr)
        {
            if (set.Contains(num + 1)) count++;
        }

        return count++;
    }
}