public class Solution
{
    //O(n)
    //O(n)
    public bool ContainsDuplicate(int[] nums)
    {
        if (nums.Length <= 0) return false;

        var dict = new Dictionary<int, int>();

        foreach (var item in nums)
        {
            if (dict.ContainsKey(item)) return true;
            dict.TryAdd(item, 0);
        }

        return false;
    }
}