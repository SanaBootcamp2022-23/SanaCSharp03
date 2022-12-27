using System.Buffers;

int n = 0, maxIndex = 0, sumOfIndex = 0, counter = 0;
double number = 0, countOfNegative = 0, maxElement = 0, maxAbsElement = 0;

Console.Write("Input size of array:");

n = int.Parse(Console.ReadLine());
double[] arr = new double[n];

Console.WriteLine("input numbers in array:");
for (int i = 0; i < n; i++) 
{
    number = double.Parse(Console.ReadLine());
    arr[i] = number;
}
Console.WriteLine("Your array:");
for (int i = 0; i < n; i++) 
{
    Console.Write($"{arr[i]} ");
}
//сума від'ємних елементів

for (int i = 0; i < n; i++)
{
    if (arr[i] < 0) 
    {
        countOfNegative += arr[i];
    }else if (arr[i] > 0) 
    {
        sumOfIndex += i;
    }
    if (maxElement < arr[i])
    {
        maxElement = arr[i];
        maxIndex = i;
    }
    if ( maxAbsElement < Math.Abs(arr[i]))
    {
        maxAbsElement = Math.Abs(arr[i]);
    }
    if(arr[i] % 1 == 0) 
    {
        counter++;
    }

}
Console.WriteLine($"\nSum of negative elements: {countOfNegative}");
Console.WriteLine($"Max element: {maxElement}\n Index of max element: {maxIndex}");
Console.WriteLine($"Max abs element: {maxAbsElement}");
Console.WriteLine($"Sum of indexes of positive elements: {sumOfIndex}");
Console.WriteLine($"Amount of whole numbers");


