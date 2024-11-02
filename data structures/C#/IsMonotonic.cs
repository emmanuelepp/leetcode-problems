//O(n)
//O(1)
public class Solution
{
    public bool IsMonotonic(int[] nums)
    {
        if (nums.Length == 0) return true;

        bool increasing = true;
        bool decreasing = true;

        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] < nums[i + 1])
                increasing = false;
            if (nums[i] > nums[i + 1])
                decreasing = false;
        }

        return increasing || decreasing;
    }
}