//O(N)
//O(N)
public class Solution
{
    public int NumIdenticalPairs(int[] nums)
    {
        if (nums.Length == 0) return -1;

        var dict = new Dictionary<int, int>();
        var result = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (dict.ContainsKey(nums[i]))
            {
                result += dict[nums[i]];
                dict[nums[i]]++;
            }
            else
                dict[nums[i]] = 1;
        }

        return result;
    }
}