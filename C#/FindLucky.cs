//O(n)
//O(n)
public class Solution
{
    public int FindLucky(int[] arr)
    {

        if (arr.Length == 0) return -1;

        var dict = new Dictionary<int, int>();

        foreach (var n in arr)
        {
            if (dict.ContainsKey(n))
                dict[n]++;
            else
                dict[n] = 1;
        }

        int max = -1;

        foreach (var n in dict)
        {
            if (n.Key == n.Value && n.Value > max) max = n.Value;
        }

        return max;
    }
}