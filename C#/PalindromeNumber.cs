//O(N)
//O(1)
public class Solution
{
    public bool IsPalindrome(int x)
    {
        if (x < 0) return false;

        var num = x.ToString();

        int L = 0, R = num.Length - 1;

        while (L < R)
        {
            if (num[L] != num[R]) return false;
            R--;
            L++;
        }

        return true;
    }
}
