//O(n)
//O(1)

public class Solution
{
    public int largestAltitude(int[] gain)
    {
        int maxAltitude = 0;
        int currentAltitude = 0;

        for (int i = 0; i < gain.Length; i++)
        {
            currentAltitude += gain[i];

            if (currentAltitude > maxAltitude) maxAltitude = currentAltitude;
        }

        return maxAltitude;
    }
}
