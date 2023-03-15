public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        var dict = new Dictionary<int, bool>();
        var count = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (!dict.ContainsKey(nums[i]))
            {
                dict.Add(nums[i], true);
                nums[count] = nums[i];
                count++;
            }
        }

        return count;
    }
}