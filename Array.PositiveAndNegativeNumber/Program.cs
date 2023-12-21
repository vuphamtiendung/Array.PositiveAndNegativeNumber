using System.Diagnostics.CodeAnalysis;
using static System.Console;
internal class Program
{
    private static void Main(string[] args)
    {
        WriteLine("Input amount in the array");
        int amount = Convert.ToInt32(ReadLine());
        int[] array = new int[amount];
        float totalPositive = 0.0f;
        float totalNegative = 0.0f;
        int countPositive = 0;
        int countNegative = 0;

        WriteLine("Input data in the array:");
        for(int index = 0; index < array.Length; index++)
        {
            array[index] = Convert.ToInt32(ReadLine());
        }

        for(int index = 0; index < array.Length; index++)
        {
            if (array[index] < 0)
            {
                totalPositive += array[index];
                countPositive++;
            }
            else if (array[index] > 0)
            {
                totalNegative += array[index];
                countNegative++;
            }
        }

        WriteLine($"Positive in array: {totalPositive/countPositive}");
        WriteLine($"Negative in array: {totalNegative/countNegative}");

        ReadLine();
    }
}