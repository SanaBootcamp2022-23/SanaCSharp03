int sumNegativeElem = 0, maxElem = int.MinValue, indexMaxElem = -1, maxAbsElem = int.MinValue, sumIndexPositiveElem = 0;

int quantityElemArr;

CheckAndWriteNumber(out quantityElemArr);

int[] arr = new int[quantityElemArr];
Random rnd = new Random();
Console.Write("arr = ");
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(-20, 20);
    Console.Write($"{arr[i]}  ");
    if (arr[i] < 0)
        sumNegativeElem += arr[i];
    if (arr[i] > maxElem)
    {
        maxElem = arr[i];
        indexMaxElem = i;
    }
    if (Math.Abs(arr[i]) > maxAbsElem)
        maxAbsElem = Math.Abs(arr[i]);
    if (arr[i] > 0)
        sumIndexPositiveElem += i;
}

Console.Write($"\nSum of negative elements = {sumNegativeElem}\n");
Console.Write($"Maximum element = {maxElem}\n");
Console.Write($"Index of maximum element = {indexMaxElem}\n");
Console.Write($"Maximum element by module = {maxAbsElem}\n");
Console.Write($"Sum index of positive element = {sumIndexPositiveElem}");

void CheckAndWriteNumber(out int number)
{
    bool isRightNumber;
    do
    {
        Console.Write($"Input quantity elements of array: ");
        isRightNumber = int.TryParse(Console.ReadLine(), out number);
        if (number <= 0)
            isRightNumber = false;
        if (!isRightNumber)
        {
            Console.Write("ERROR!!!\n");
        }
    } while (!isRightNumber);
}