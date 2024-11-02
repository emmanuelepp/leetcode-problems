// O(N)
// O(1)

#include <unordered_map>
#include <string>

class Solution
{
public:
    bool isStrobogrammatic(std::string num)
    {
        std::unordered_map<char, char> strobogrammaticPairs = {
            {'0', '0'}, {'1', '1'}, {'6', '9'}, {'8', '8'}, {'9', '6'}};

        int L = 0, R = num.size() - 1;
        while (L <= R)
        {
            if (strobogrammaticPairs.find(num[L]) == strobogrammaticPairs.end() ||
                strobogrammaticPairs[num[L]] != num[R])
                return false;
            L++;
            R--;
        }

        return true;
    }
};