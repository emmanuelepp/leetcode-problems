//O(n)
//O(n)
public class Solution
{
    public int SumOfUnique(int[] nums)
    {

        if (nums.Length == 0) return 0;

        var dict = new Dictionary<int, int>();

        foreach (var n in nums)
        {
            if (dict.ContainsKey(n))
                dict[n]++;
            else
                dict[n] = 1;
        }

        var num = 0;

        foreach (var n in nums)
        {
            if (dict[n] == 1)
            {
                num += n;
            }
        }

        return num;
    }
}