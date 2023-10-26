//O(N+M)
//O(N+M)
public class Solution
{
    public int[] Intersection(int[] nums1, int[] nums2)
    {

        var setNumsOne = new HashSet<int>(nums1);
        var setNumsTwo = new HashSet<int>(nums2);
        var result = new List<int>();

        foreach (var item in setNumsOne)
        {
            if (setNumsTwo.Contains(item))
                result.Add(item);
        }

        return result.ToArray();
    }
}