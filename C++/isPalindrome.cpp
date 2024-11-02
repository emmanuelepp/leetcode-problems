// Time: O(N)
// Space: O(N)
#include <string>

class Solution
{
public:
    bool isPalindrome(int x)
    {
        if (x == 0)
            return true;
        if (x < 0)
            return false;

        auto num = std::to_string(x);
        int L = 0, R = num.size() - 1;

        while (L < R)
        {
            if (num[L] != num[R])
                return false;
            L++;
            R--;
        }

        return true;
    }
};