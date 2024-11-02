//O(N)
//O(1)
public class Solution
{
    public bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        if (nums.Length <= 0 || k <= 0) return false;

        var numToIndex = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (numToIndex.ContainsKey(nums[i]))
            {
                int prevIndex = numToIndex[nums[i]];
                if (i - prevIndex <= k)
                {
                    return true;
                }
            }

            numToIndex[nums[i]] = i;
        }

        return false;
    }
}