//O(n)
//O(n)
public class Solution
{

    private Dictionary<int, int> dictMemo = new Dictionary<int, int>();

    public int Fib(int n)
    {

        if (n <= 1) return n;

        if (dictMemo.ContainsKey(n))
            return dictMemo[n];

        dictMemo[n] = Fib(n - 1) + Fib(n - 2);

        return dictMemo[n];
    }
}
