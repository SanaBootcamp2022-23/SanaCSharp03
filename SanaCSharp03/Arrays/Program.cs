// See https://aka.ms/new-console-template for more information
int inputN, max = 0, summa = 0, integers = 0;
double sumNegative = 0, maxElement = 0, maxAbs = 0;

Console.WriteLine("Enter the length of the array:");
inputN = int.Parse(Console.ReadLine());

double[]arr = new double[inputN];

for (int i = 0; i < inputN; i++)
{
    Console.Write($"Element [{i}] = ");
    arr[i] = double.Parse(Console.ReadLine());

    if (arr[i] < 0)
    {
        sumNegative += arr[i];
    }

    if (arr[i] > maxElement)
    {
        maxElement = arr[i];
        max = i;
    }

    if (Math.Abs(arr[i]) > maxAbs) 
    {
        maxAbs = Math.Abs(arr[i]);
    }

    if (arr[i] > 0)
    {
        summa += i;
    }

    if (arr[i] % 1 == 0)
    {
        integers++;
    }
}

Console.WriteLine($"The sum of the negative elements of the array: {sumNegative}");
Console.WriteLine($"Maximum element of an array: {maxElement}");
Console.WriteLine($"Index of the maximum element of the array: {max}");
Console.WriteLine($"Maximum modulo element of the array: {maxAbs}");
Console.WriteLine($"Sum of positive element indices: {summa}");
Console.WriteLine($"Number of integers in an array: {integers}");



