// Time: O(N)
// Space: O(N)
#include <vector>
#include <unordered_map>

class Solution
{
public:
    bool containsNearbyDuplicate(std::vector<int> &nums, int k)
    {
        if (nums.empty())
            return false;

        std::unordered_map<int, int> map;

        for (int i = 0; i < nums.size(); i++)
        {

            if (map.find(nums[i]) != map.end() && abs(i - map[nums[i]]) <= k)
            {
                return true;
            }
            map[nums[i]] = i;
        }

        return false;
    }
};