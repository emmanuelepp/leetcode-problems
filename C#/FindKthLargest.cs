//O(n)
//O(1)

public class Solution
{
    public int FindKthlargest(int[] nums, int k)
    {
        return QuickSelect(nums, 0, nums.length - 1, nums.length - k);
    }

    private static int QuickSelect(int[] nums, int l, int r, int k)
    {
        int p = Partition(nums, l, r);

        if (p > k) return QuickSelect(nums, l, p - 1, k);
        else if (p < k) return QuickSelect(nums, p + 1, r, k);
        else return nums[p];
    }

    private static int Partition(int[] nums, int l, int r)
    {
        int pivot = nums[r];
        int i = l;

        for (int j = l; j < r; j++)
        {
            if (nums[j] <= pivot)
            {
                (nums[i], nums[j]) = (nums[j], nums[i]);
                i++;
            }
        }
        (nums[i], nums[r]) = (nums[r], nums[i]);

        return i;
    }
}
