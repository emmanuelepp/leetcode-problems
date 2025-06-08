// O(n)
// O(1)

public class Solution
{
    public int[] runningSum(int[] nums)
    {
        int[] result = new int[nums.Length];
        int sum = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            sum = sum + nums[i];
            result[i] = sum;
        }

        return result;
    }
}
