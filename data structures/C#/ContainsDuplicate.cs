//O(n)
//O(n)
public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {

        if (nums.Length == 0) return false;

        var set = new HashSet<int>(nums);

        return nums.Length > set.Count ? true : false;
    }
}