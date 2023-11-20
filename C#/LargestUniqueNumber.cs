//O(n)
//O(n)
public class Solution
{
    public int LargestUniqueNumber(int[] nums)
    {

        int maxInt = -1;

        var dict = new Dictionary<int, int>();

        foreach (var num in nums)
        {
            if (dict.ContainsKey(num))
                dict[num]++;
            else
                dict[num] = 1;
        }

        foreach (var num in nums)
        {
            if (dict.ContainsKey(num) && dict[num] == 1 && num > maxInt)
                maxInt = num;
        }

        return maxInt;
    }
}