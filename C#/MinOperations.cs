//O(N)
//O(N)
public class Solution
{
    public int MinOperations(int[] nums)
    {
        var dict = new Dictionary<int, int>();
        var result = 0;

        foreach (int num in nums)
        {
            if (dict.ContainsKey(num))
                dict[num]++;
            else
                dict[num] = 1;
        }

        foreach (KeyValuePair<int, int> val in dict)
        {
            if (val.Value == 1) return -1;
            else if (val.Value % 3 == 0) result += val.Value / 3;
            else result += val.Value / 3 + 1;
        }

        return result;
    }
}
