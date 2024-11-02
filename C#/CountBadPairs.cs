//O(n)
//O(1)
public class Solution
{
    public long CountBadPairs(int[] nums)
    {
        long countBadPairs = 0;
        var diffCount = new Dictionary<int, long>();

        for (int i = 0; i < nums.Length; i++)
        {
            int diff = nums[i] - i;

            countBadPairs += i - (diffCount.ContainsKey(diff) ? diffCount[diff] : 0);

            if (!diffCount.ContainsKey(diff))
            {
                diffCount[diff] = 0;
            }
            diffCount[diff]++;
        }

        return countBadPairs;
    }
}
