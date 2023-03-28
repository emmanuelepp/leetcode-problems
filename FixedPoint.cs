//O(n)
//O(1)
public class Solution
{
    public int FixedPoint(int[] arr)
    {
        if (arr.Length <= 0) return -1;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == i)
            {
                return arr[i];
            }
        }
        return -1;
    }
}