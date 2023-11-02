//O(n^2)
//O(n)
public class Solution
{
    public int CountPairs(IList<int> nums, int target)
    {

        if (nums.Count == 0) return 0;

        var count = 0;

        for (int i = 0; i < nums.Count; i++)
        {
            for (int j = i + 1; j < nums.Count; j++)
            {
                if (nums[i] + nums[j] < target)
                    count++;
            }
        }

        return count;
    }
}