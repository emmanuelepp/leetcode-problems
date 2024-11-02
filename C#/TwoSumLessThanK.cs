// O(n log n)
// Time: O(1)
public class Solution
{
    public int TwoSumLessThanK(int[] nums, int k)
    {
        if (nums.Length <= 0 || nums == null) return -1;
        int L = 0, R = nums.Length - 1;
        int maxSum = -1;
        Array.Sort(nums);

        while (L < R)
        {
            int sum = nums[L] + nums[R];
            if (sum < k)
            {
                maxSum = Math.Max(maxSum, sum);
                L++;
            }
            else
            {
                R--;
            }
        }

        return maxSum;
    }
}
