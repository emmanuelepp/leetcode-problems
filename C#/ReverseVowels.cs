//O(N)
//O(1)
public class Solution
{
    public string ReverseVowels(string s)
    {
        if (string.IsNullOrEmpty(s)) return "";
        int L = 0, R = s.Length - 1;
        var result = s.ToCharArray();
        var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

        while (L < R)
        {
            if (vowels.Contains(result[L]) && vowels.Contains(result[R]))
            {
                var temp = result[L];
                result[L] = result[R];
                result[R] = temp;
                L++;
                R--;
            }
            else if (!vowels.Contains(result[L]))
            {
                L++;
            }
            else if (!vowels.Contains(result[R]))
            {
                R--;
            }
        }

        return new string(result);
    }
}