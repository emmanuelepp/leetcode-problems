//O(n)
//O(n)

public class Solution
{
    public int[] SortArrayByParity(int[] nums)
    {

        if (nums.Length == 0) return new int[] { };

        int L = 0, R = nums.Length - 1;

        while (L < R)
        {
            if (nums[L] % 2 != 0 && nums[R] % 2 == 0)
            {
                (nums[R], nums[L]) = (nums[L], nums[R]);
                L++;
                R--;
            }
            else if (nums[L] % 2 != 0)
            {
                R--;
            }
            else
            {
                L++;
            }
        }

        return nums;
    }
}