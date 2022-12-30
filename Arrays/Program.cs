Console.Write("Please, enter N integer amount of array elements: ");
uint n = uint.Parse(Console.ReadLine());

double[] arr = new double[n];

for (int i = 0; i < n; i++)
{
    Console.Write($"Enter number in {i} element: ");
    arr[i] = double.Parse(Console.ReadLine());
}

countSumNegative(arr);
findMaxElementAndIndex(arr);
findMaxAbsElement(arr);
countSumOfIndexesPositiveElements(arr);
countIntegerNumbers(arr);



void countSumNegative(double[] arr)
{
    double sumNegative = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0) { sumNegative += arr[i]; }
    }
    Console.WriteLine($"Sum negative elements of array: {sumNegative}.");
}

void findMaxElementAndIndex(double[] arr)
{
    double maxElement = double.MinValue;
    uint indexOfMaxElement = 0;

    for (uint i = 0; i < arr.Length; i++)
    {
        if (arr[i] > maxElement)
        {
            maxElement = arr[i];
            indexOfMaxElement = i;
        }
    }
    Console.WriteLine($"Max element of array is: {maxElement} in {indexOfMaxElement} array index.");
}

void findMaxAbsElement(double[] arr)
{
    double maxAbsElement = double.MinValue;

    for (uint i = 0; i < arr.Length; i++)
    {
        if (Math.Abs(arr[i]) > maxAbsElement)
        {
            maxAbsElement = arr[i];
        }
    }
    Console.WriteLine($"Max absolute value of array elements is: {maxAbsElement}.");
}

void countSumOfIndexesPositiveElements(double[] arr)
{
    uint sumOfIndexPositiveValues = 0;

    for (uint i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            sumOfIndexPositiveValues += i;
        }
    }
    Console.WriteLine($"Sum of indexes positive values in array elements is: {sumOfIndexPositiveValues}.");
}

void countIntegerNumbers(double[] arr) {
    uint countsOfIntNumbers = 0;

    for (uint i = 0; i < arr.Length; i++)
        {
            if (arr[i] == Math.Round(arr[i],0))
            {
                countsOfIntNumbers++;
            }
        }
    Console.WriteLine($"Counts of int numbers in array is: {countsOfIntNumbers}.");
    } 