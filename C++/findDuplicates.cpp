// O(N)
// O(1)
#include <vector>
#include <map>

class Solution {
public:
    std::vector<int> findDuplicates(std::vector<int>& nums) {

        if(nums.size()== 0) return std::vector<int>{};

        std::vector<int> result;
        std::map<int,int> map;

        for(int i = 0; i < nums.size(); i++)
        {
            if(map.find(nums[i])!= map.end())
                result.push_back(nums[i]);
            else
            map[nums[i]]++;
        }

        return result; 
    }
};