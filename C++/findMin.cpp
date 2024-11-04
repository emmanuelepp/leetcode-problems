// Time: O(Log n)
// Space: O(1)

#include <vector>

class Solution
{
public:
    int findMin(std::vector<int> &nums)
    {

        if (nums.empty())
            return -1;

        int L = 0, R = nums.size() - 1;

        while (L < R)
        {
            int mid = L + (R - L) / 2;
            if (nums[mid] < nums[R])
                R = mid;
            else
                L = mid + 1;
        }

        return nums[L];
    }
};