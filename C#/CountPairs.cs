//O(n log n)
//O(n)
public class Solution
{
    public int CountPairs(IList<int> nums, int target)
    {

        if (nums.Count == 0) return 0;
        int L = 0, R = nums.Count - 1;
        var sortedNums = nums.OrderBy(n => n).ToList();
        var count = 0;

        while (L < R)
        {
            if (sortedNums[L] + sortedNums[R] < target)
            {
                count += R - L;
                L++;
            }
            else
            {
                R--;
            }
        }

        return count;
    }
}