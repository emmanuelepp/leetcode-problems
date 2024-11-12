// Time: O(N)
// Space: O(1)

#include <vector>

class Solution
{
public:
    int sumOfDigits(std::vector<int> &nums)
    {
        if (nums.empty())
            return 0;

        int min = nums[0];
        int sum = 0;

        for (int i = 1; i < nums.size(); i++)
        {
            if (nums[i] < min)
            {
                min = nums[i];
            }
        }

        while (min > 0)
        {
            sum += min % 10;
            min /= 10;
        }

        return sum % 2 == 0 ? 1 : 0;
    }
};