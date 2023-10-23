//O(N)
//O(N)
public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {

        if (nums.Length == 0) return new int[] { };

        var dict = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int result = target - nums[i];

            if (dict.ContainsKey(result))
            {
                return new int[] { dict[result], i };
            }

            dict[nums[i]] = i;
        }

        return new int[] { };
    }
}