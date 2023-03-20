using System.Collections;

public class Solution
{
    //O(n)
    //O(n)
    public bool ContainsDuplicate(int[] nums)
    {
        if (nums.Length <= 1) return false;
        var hashSet = new HashSet<int>();

        foreach (var item in nums)
        {
            if (hashSet.Contains(item))
            {
                return true;
            }
            else
            {
                hashSet.Add(item);
            }
        }
        
        return false;
    }
}