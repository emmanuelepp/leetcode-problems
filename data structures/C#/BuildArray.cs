//O(n)
//O(n)
public class Solution
{
    public int[] BuildArray(int[] nums)
    {

        var ans = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            ans[i] = nums[nums[i]];
        }

        return ans;
    }
}
