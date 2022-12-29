using System.Diagnostics.Metrics;

double number = 0, sumnegative = 0, maxelem = 0, abselem = 0, max = 0, n = 0, sumplus = 0, sumindex = 0, sumreal = 0;

Console.Write("What size of array:");
n = int.Parse(Console.ReadLine());
double[] arr = new double[(int)n];

Console.Write("Enter numbers in array:\n");
for (int i = 0; i < n; i++)
{
    number = double.Parse(Console.ReadLine());
    arr[i] = number;
}
for (int i = 0; i < n; i++)
{
    if (arr[i] < 0)
    {
        sumnegative += arr[i];
    }
    else if (arr[i] > 0)
    {
        sumplus += arr[i];
    }

    if (max < arr[i])
    {
        maxelem = i;
        max = arr[i];
    }
    if (abselem < Math.Abs(arr[i]))
    {
        abselem = Math.Abs(arr[i]);
    }
    if (arr[i] > 0)
    {
        sumindex += i;
    }
    if (arr[i] % 1 == 0)
    {
        sumreal += 1;
     }
}

Console.WriteLine($"Negative elements sum - ({sumnegative})");
Console.WriteLine($"Max array element - ({max})");
Console.WriteLine($"Index of max array element - ({maxelem})");
Console.WriteLine($"Max with ABS element - ({abselem})");
Console.WriteLine($"Sum of index`s of positive elements - ({sumindex})");
Console.WriteLine($"Count of real numbers - ({sumreal})");