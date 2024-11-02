//O(n)
//O(n)
public class Solution
{
    public int RepeatedNTimes(int[] nums)
    {
        if (nums.Length == 0) return 0;

        var dict = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (dict.ContainsKey(nums[i]))
                dict[nums[i]]++;
            else
                dict[nums[i]] = 1;
        }

        foreach (var num in nums)
        {
            if (dict[num] > 1) return num;
        }

        return 0;
    }
}