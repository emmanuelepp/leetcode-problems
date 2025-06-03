//O(n log n)
//O(n)
public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {

        if (nums.Length == 0) return new int[] { };

        var result = new List<int>();
        var freq = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (freq.ContainsKey(nums[i])) freq[nums[i]]++;
            else freq[nums[i]] = 1;
        }

        var ordered = freq.OrderByDescending(pair => pair.Value).ToList();

        for (int i = 0; i < k; i++)
        {
            result.Add(ordered[i].Key);
        }

        return result.ToArray();
    }
}
