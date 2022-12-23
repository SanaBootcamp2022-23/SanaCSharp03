// See https://aka.ms/new-console-template for more information

Console.Write("Input count of elements on array: ");
int countArray = int.Parse(Console.ReadLine());
double []arr = new double[countArray];
double negativeSum = 0, maxElement = 0, maxAbsElement = 0; 
int maxElementIndex = 0, positSumIndex = 0, intNumCount = 0;

for (int i = 0; i < countArray; i++)
{
    Console.Write($"Enter Array[{i}]: ");
    arr[i] = double.Parse(Console.ReadLine());

    if (arr[i] > maxElement)
    {
        maxElement = arr[i];
        maxElementIndex = i;
    }

    if (arr[i] < 0)
    {
        negativeSum += arr[i];
    }
    else
    {
        positSumIndex += i;
    }

    if (Math.Abs(arr[i]) > Math.Abs(maxAbsElement))
        maxAbsElement = Math.Abs(arr[i]);

    if (arr[i] % 1 == 0)
        intNumCount ++;
}
Console.WriteLine($"\nNegative sum = {negativeSum}");
Console.WriteLine($"Max array element = {maxElement}, his number = {maxElementIndex}");
Console.WriteLine($"Max abs array element = {maxAbsElement}");
Console.WriteLine($"Sum of positiv element index = {positSumIndex}");
Console.WriteLine($"Count of int element = {intNumCount}");