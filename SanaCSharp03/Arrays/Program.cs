int N;
do
{
    Console.Write("Enter number of elements: ");
    N = int.Parse(Console.ReadLine());
    if (N <= 0)
    {
        Console.WriteLine("Invalid value. Try again");
    }
} while (N <= 0);
double[] arr = new double[N];
for (int i = 0; i < N; i++)
{
    Console.Write($"Enter element {i + 1}: ");
    arr[i] = double.Parse(Console.ReadLine());
}
double NegSum = 0;
double max = arr[0];
double maxModuleEl = Math.Abs(arr[0]);
int SumOfInd = 0, indexmax = 0, IntCount = 0;
for (int i = 0; i < N; i++)
{
    if (arr[i] < 0)
    {
        NegSum += arr[i];
    }
    if (arr[i] > max)
    {
        max = arr[i];
        indexmax = i + 1;
    }
    if (Math.Abs(arr[i]) > maxModuleEl)
    {
        maxModuleEl = Math.Abs(arr[i]);
    }
    if (arr[i] > 0)
    {
        SumOfInd += i + 1;
    }
    if (arr[i] % 1 == 0)
    {
        IntCount++;
    }
}
Console.WriteLine($"Sum of negative number: {NegSum}");
Console.WriteLine($"Max element in array: {max}");
Console.WriteLine($"Index of max element: {indexmax}");
Console.WriteLine($"Max abs element in array: {maxModuleEl}");
Console.WriteLine($"Sum of positive index: {SumOfInd}");
Console.WriteLine($"Amount of integer number in array: {IntCount}");