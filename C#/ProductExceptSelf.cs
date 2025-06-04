//O(n)
//O(1)
public class Solution
{
    public int[] ProductExceptSelf(int[] nums)
    {

        var n = nums.Length;
        var prefix = new int[n];
        var suffix = new int[n];
        var result = new int[n];

        prefix[0] = 1;

        // Build prefix products (left side of each index)
        for (int i = 1; i < n; i++)
        {
            prefix[i] = prefix[i - 1] * nums[i - 1];
        }

        // Build suffix products (right side of each index)
        suffix[n - 1] = 1;
        for (int i = n - 2; i >= 0; i--)
        {
            suffix[i] = suffix[i + 1] * nums[i + 1];
        }

        // Multiply prefix and suffix to get final result
        for (int i = 0; i < n; i++)
        {
            result[i] = prefix[i] * suffix[i];
        }

        return result;
    }
}
