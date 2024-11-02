//O(n*m)
//O(n)
public class Solution
{
    public int NumOfPairs(string[] nums, string target)
    {
        if (nums.Length == 0) return 0;
        var count = 0;
        var dict = new Dictionary<string, int>();

        foreach (var num in nums)
        {
            if (dict.ContainsKey(num))
                dict[num]++;
            else
                dict.Add(num, 1);
        }

        foreach (var num in nums)
        {
            var complement = target.StartsWith(num) ? target.Substring(num.Length) : null;

            if (complement != null && dict.ContainsKey(complement))
                count += (complement == num) ? dict[complement] - 1 : dict[complement];
        }

        return count;
    }
}
