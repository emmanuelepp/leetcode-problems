//O(n)
//O(1)
public class Solution
{
    public bool ThreeConsecutiveOdds(int[] arr)
    {
        if (arr.Length <= 0 && arr == null) return false;

        int odd = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 != 0)
            {
                odd++;
            }
            else
            {
                odd = 0;
            }

            if (odd == 3)
            {
                return true;
            }
        }

        return false;
    }
}