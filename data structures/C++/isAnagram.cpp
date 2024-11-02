// Time: O(N)
// Space: O(1)

#include <string>
#include <unordered_map>

class Solution
{
public:
    bool isAnagram(std::string s, std::string t)
    {
        if (s.size() != t.size())
            return false;

        std::unordered_map<char, int> word1;
        std::unordered_map<char, int> word2;

        for (char c : s)
        {
            word1[c]++;
        }

        for (char c : t)
        {
            word2[c]++;
        }

        return word1 == word2;
    }
};