//O(N)
//O(M+N)
public class Solution
{
    public int NumJewelsInStones(string jewels, string stones)
    {

        if (string.IsNullOrEmpty(jewels) || string.IsNullOrEmpty(stones)) return 0;

        int count = 0;

        var jewelCharsSet = new HashSet<char>(jewels);

        for (int i = 0; i < stones.Length; i++)
        {
            if (jewelCharsSet.Contains(stones[i]))
            {
                count++;
            }
        }

        return count;
    }
}