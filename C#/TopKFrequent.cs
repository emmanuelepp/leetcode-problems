//O(n * k)
//O(n)
public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {

        if (nums.Length == 0) return new int[] { };

        var dict = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (!dict.ContainsKey(nums[i]))
                dict[nums[i]] = 1;
            else
                dict[nums[i]]++;
        }

        var mostFrecuentElements = new List<int>();

        while (k > 0)
        {
            int maxFreq = -1;
            int number = -1;

            foreach (var item in dict)
            {
                if (item.Value > maxFreq)
                {
                    maxFreq = item.Value;
                    number = item.Key;
                }
            }

            mostFrecuentElements.Add(number);
            dict.Remove(number);
            k--;
        }

        return mostFrecuentElements.ToArray();
    }
}