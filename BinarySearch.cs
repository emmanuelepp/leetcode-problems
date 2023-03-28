//O(Logn)
//O(1)
public class Solution
{
    public int Search(int[] nums, int target)
    {

        if (nums == null || nums.Length == 0) return -1;

        int L = 0, R = nums.Length - 1;

        while (L <= R)
        {
            int mid = L + (R - L) / 2;

            if (nums[mid] == target) return mid;

            if (nums[mid] < target)
            {
                L = mid + 1;
            }
            else
            {
                R = mid - 1;
            }
        }

        return -1;
    }
}