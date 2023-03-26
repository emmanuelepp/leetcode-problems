//O(n)
//O(n)
public class Solution
{
    public string DefangIPaddr(string address)
    {
        if (string.IsNullOrWhiteSpace(address)) return "";

        return string.Join(".", address).Replace(".", "[.]");
    }
}