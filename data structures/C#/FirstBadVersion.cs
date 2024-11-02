//O(Logn)
//O(1)
public class Solution : VersionControl
{
    public int FirstBadVersion(int n)
    {
        if (n < 0) return 0;

        int L = 1, R = n;

        while (L < R)
        {
            int mid = L + (R - L) / 2;

            if (IsBadVersion(mid))
                R = mid;
            else
                L = mid + 1;
        }

        return L;
    }
}