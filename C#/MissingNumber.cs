//O(N)
//O(1)
public class Solution
{
    public int MissingNumber(int[] nums)
    {

        int result = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            result ^= nums[i];
        }

        for (int i = 0; i <= nums.Length; i++)
        {
            result ^= i;
        }

        return result;
    }
}