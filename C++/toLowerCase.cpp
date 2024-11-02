// Time: O(N)
// Spce: O(N)
#include <string>

class Solution
{
public:
    std::string toLowerCase(std::string s)
    {
        if (s.empty())
            return "";

        std::string result;

        for (char c : s)
        {
            if (c >= 'A' && c <= 'Z')
                c = c + 32;
            result += c;
        }

        return result;
    }
};