class Solution
{
public:
    vector<int> twoSum(vector<int> &nums, int target)
    {

        if (nums.size() == 0)
            return vector<int>{};

        for (int i = 0; i < nums.size(); i++)
        {
            for (int j = 0; j < i; j++)
            {
                int sum = nums[i] + nums[j];
                if (sum == target)
                {
                    return vector<int>{i, j};
                }
            }
        }

        return vector<int>{};
    }
};