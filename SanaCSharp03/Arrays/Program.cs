
uint N;
Console.WriteLine("Enter size array N:");
if(!uint.TryParse(Console.ReadLine(), out N))
{
    Console.WriteLine("Error! Enter number");
    return;
}

double[] arr = new double[N];

for(uint i = 0; i < arr.Length; i++)
{
    Console.WriteLine("Enter number for array element:");
    if(!double.TryParse(Console.ReadLine(), out arr[i]))
    {
        Console.WriteLine("Error! Enter number");
        return;
    }
}

Console.WriteLine("-----------------------------------------");

double sumNegative = 0, maxElement = arr[0], maxElementModule = arr[0];
uint maxElementIndex = 0, countInteger = 0;
long sumIndexPositive = 0;

for(uint i = 0; i < arr.Length; i++)
{
    if (arr[i] < 0)
        sumNegative += arr[i];
    else sumIndexPositive += i;

    if (maxElement < arr[i])
    {
        maxElement = arr[i];
        maxElementIndex = i;
    }
    
    if (Math.Abs(maxElementModule) < Math.Abs(arr[i]))
        maxElementModule = arr[i];

    if (arr[i] == Math.Truncate(arr[i]))
        countInteger++;
}

Console.Write("arr = ( ");
foreach (var x in arr)
    Console.Write($"{x}  ");
Console.WriteLine(")\n");

Console.WriteLine($"sum negative array elements: {sumNegative}");
Console.WriteLine($"Max array element: {maxElement}");
Console.WriteLine($"Index max array element: {maxElementIndex}");
Console.WriteLine($"Max array element by module: [{maxElementModule}]");
Console.WriteLine($"Sum index positive array elements: {sumIndexPositive}");
Console.WriteLine($"Count integer number in array: {countInteger}");

