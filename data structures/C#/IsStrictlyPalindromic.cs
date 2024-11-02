//O(logn)
//O(1)
public class Solution
{
    public bool IsStrictlyPalindromic(int n)
    {
        if (n == 0) return true;

        string binary = Convert.ToString(n, 2);

        int L = 0, R = binary.Length - 1;

        while (L >= R)
        {
            if (binary[L] == binary[R])
            {
                return true;
            }
            L++;
            R--;
        }
        return false;
    }
}