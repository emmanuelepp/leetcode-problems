// O(N)
// O(1)

#include <vector>

class Solution {
public:
    void reverseString(std::vector<char>& s) {

        if(s.empty()) return;

        int L = 0, R = s.size() -1;

        while( L < R)
        {
            char temp = s[L];
            s[L] = s[R];
            s[R] = temp;
            L++;
            R--;
        }
    }
};