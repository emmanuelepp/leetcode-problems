//O(n)
//O(1)

public class Solution
{
    public int FindKthLargest(int[] nums, int k)
    {
        return QuickSelect(nums, 0, nums.Length - 1, nums.Length - k);
    }

    private static int QuickSelect(int[] nums, int L, int R, int k)
    {
        int p = Partition(nums, L, R);

        if (p > k) return QuickSelect(nums, L, p - 1, k);
        else if (p < k) return QuickSelect(nums, p + 1, R, k);
        else return nums[p];
    }

    private static int Partition(int[] nums, int L, int R)
    {
        int pivot = nums[R];
        int i = L;

        for (int j = L; j < R; j++)
        {
            if (nums[j] <= pivot)
            {
                (nums[i], nums[j]) = (nums[j], nums[i]);
                i++;
            }
        }
        (nums[i], nums[R]) = (nums[R], nums[i]);

        return i;
    }
}
