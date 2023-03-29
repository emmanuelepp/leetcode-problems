//O(n)
//O(1)
public class Solution
{
    public int FindDuplicate(int[] nums)
    {
        if (nums == null || nums.Length <= 0) return -1;

        var hashSet = new HashSet<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (hashSet.Contains(nums[i]))
            {
                return nums[i];
            }

            hashSet.Add(nums[i]);
        }

        return -1;
    }
}