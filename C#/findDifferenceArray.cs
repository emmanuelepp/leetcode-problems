//O(n)
//O(n)

public class Solution
{
    public int[] findDifferenceArray(int[] nums)
    {
        int n = nums.Length;
        int[] differenceArray = new int[n];
        int[] prefix = new int[n];
        int[] suffix = new int[n];

        prefix[0] = 0;
        for (int i = 1; i < n; i++)
            prefix[i] = prefix[i - 1] + nums[i - 1];

        suffix[n - 1] = 0;
        for (int i = n - 2; i >= 0; i--)
            suffix[i] = suffix[i + 1] + nums[i + 1];

        for (int i = 0; i < n; i++)
            differenceArray[i] = Math.Abs(prefix[i] - suffix[i]);

        return differenceArray;
    }
}
