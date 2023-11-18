//O(n)
//O(n)
public class Solution
{
    public int[] Intersect(int[] nums1, int[] nums2)
    {

        if (nums1.Length == 0 || nums2.Length == 0) return new int[] { 1 };

        var result = new List<int> { };
        var dict = new Dictionary<int, int>();

        for (int i = 0; i < nums2.Length; i++)
        {
            if (dict.ContainsKey(nums2[i]))
                dict[nums2[i]]++;
            else
                dict[nums2[i]] = 1;
        }

        for (int i = 0; i < nums1.Length; i++)
        {
            if (dict.ContainsKey(nums1[i]) && dict[nums1[i]] > 0)
            {
                result.Add(nums1[i]);
                dict[nums1[i]]--;
            }
        }

        return result.ToArray();
    }
}