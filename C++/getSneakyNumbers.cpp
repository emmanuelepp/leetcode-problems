// O(N)
// O(1)

#include <vector>
#include <map>

class Solution {
public:
    std::vector<int> getSneakyNumbers(std::vector<int>& nums) {

        if(nums.empty()) return std::vector<int>{};

        std::vector<int> result;
        std::map<int,int> map;

        for(int i =0; i < nums.size(); i++)
        {
            if(map.find(nums[i]) != map.end())
                map[nums[i]]++;
            else
                map[nums[i]] = 1;
        }

        for(auto num : map)
        {
            if(num.second == 2) result.push_back(num.first);
        }

        return result;
    }
};