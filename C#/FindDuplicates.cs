//O(n)
//O(n)
public class Solution
{
    public IList<int> FindDuplicates(int[] nums)
    {

        if (nums.Length < 0) return new List<int> { };

        var dict = new Dictionary<int, int>();
        var duplicateNumbersList = new List<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (dict.ContainsKey(nums[i]))
                duplicateNumbersList.Add(nums[i]);
            else
                dict.Add(nums[i], i);
        }

        return duplicateNumbersList;
    }
}