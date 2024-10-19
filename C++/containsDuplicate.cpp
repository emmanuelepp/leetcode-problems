// O(N)
// O(1)
#include <vector>
#include <set>

class Solution {
public:
    bool containsDuplicate(std::vector<int>& nums) {

        if(nums.empty()) return false;

        std::set<int> numbers;

        for(int i = 0; i < nums.size(); i++)
        {
            if(numbers.find(nums[i]) != numbers.end())
                return true;
            else
                numbers.insert(nums[i]);
        }

        return false;
    }
};