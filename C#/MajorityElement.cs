//O(n)
//O(n)
public class Solution
{
    public int MajorityElement(int[] nums)
    {

        if (nums.Length <= 0) return -1;

        var dict = new Dictionary<int, int>();
        var majorityElement = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (!dict.ContainsKey(nums[i]))
                dict[nums[i]] = 1;
            else
                dict[nums[i]]++;

            if (dict[nums[i]] > nums.Length / 2)
                return nums[i];
        }

        return -1;
    }
}