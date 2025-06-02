//O(n)
//O(n)
public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        if (nums.Length == 0) return false;

        var hashSet = new HashSet<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (hashSet.Contains(nums[i])) return true;
            else hashSet.Add(nums[i]);
        }

        return false;
    }
}