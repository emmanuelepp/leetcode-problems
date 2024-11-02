// O(N)
// O(1)
#include <vector>
class Solution {
public:
    int removeDuplicates(std::vector<int>& nums) {
        if (nums.empty()) return 0;

        int result = 1;

        for(int i = 0; i < nums.size(); i++)
        {
            if(nums[i] != nums[result -1])
            {
                nums[result++] = nums[i];
            }
        }

        return result;
    }
};