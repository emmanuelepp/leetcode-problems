// Time: O(N)
// Space: O(1)

#include <vector>
class Solution
{
public:
    std::vector<int> shuffle(std::vector<int> &nums, int n)
    {
        if (nums.empty() || n < 0)
            return {};

        std::vector<int> result(2 * n);
        int index = 0;

        for (int i = 0; i < n; ++i)
        {
            result[index++] = nums[i];
            result[index++] = nums[n + i];
        }

        return result;
    }
};
