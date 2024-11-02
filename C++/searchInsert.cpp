// O(Log N)
// O(1)
#include <vector>

class Solution {
public:
    int searchInsert(std::vector<int>& nums, int target) {

        if(nums.empty()) return -1;

        int L = 0, R = nums.size() -1;

        while(L <= R)
        {
            int mid = L + (R - L) / 2;

            if(nums[mid] == target) return mid;
            else if(nums[mid] > target)
                R = mid - 1;
            else
                L = mid + 1;
        }
        return L;
    }
};