//O(n)
//o(1)
public class Solution
{
    public int SingleNumber(int[] nums)
    {
        if (nums.Length == 1) return nums[0];
        var dict = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (!dict.ContainsKey(nums[i])) dict[nums[i]] = i;
            else dict.Remove(nums[i]);
        }

        return dict.Keys.First();
    }
}