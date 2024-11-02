//O(N)
//O(1)
public class Solution
{
    public int MinOperations(int[] nums, int k)
    {

        if (nums.Length == 0) return -1;

        int count = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] < k) count++;
        }

        return count;
    }
}