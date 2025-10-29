//O(n)
//O(1)

public class Solution
{
    public bool IsBalanced(string num)
    {

        if (num.Length == 0) return false;

        int even = 0, odd = 0;

        for (int i = 0; i < num.Length; i++)
        {
            int digit = num[i] - '0';

            if (i % 2 == 0) even += digit;
            else odd += digit;
        }

        if (even == odd) return true;
        else return false;

    }
}