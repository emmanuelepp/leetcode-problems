public class Solution
{
    //O(n)
    //O(n)
    public int[] TwoSum(int[] nums, int target)
    {
        if (nums.Length <= 1) return new int[] { };
        var dict = new Dictionary<int, int>();
        
        for (int i = 0; i < nums.Length; i++)
        {
            int result = target - nums[i];
            if (dict.ContainsKey(result)) return new int[] { i, dict[result] };
            dict[nums[i]] = i;
        }

        return new int[] { };
    }
}