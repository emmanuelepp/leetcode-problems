//O(1)
//O(1)
public class Solution
{
    public double[] ConvertTemperature(double celsius)
    {
        var kelvin = celsius + 273.15;
        var fahrenheit = celsius * 1.80 + 32.00;

        return new double[] { kelvin, fahrenheit };
    }
}