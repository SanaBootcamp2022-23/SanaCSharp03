double sumNegativeElem = 0, maxElem = int.MinValue, indexMaxElem = -1, maxAbsElem = int.MinValue, sumIndexPositiveElem = 0;

int quantityElemArr, quantityWholeNumber = 0;

CheckAndWriteNumber(out quantityElemArr);

double[] arr = new double[quantityElemArr];
Random rnd = new Random();
Console.Write("arr = ");
for (int i = 0; i < arr.Length; i++)
{
    int checkWholeFractionalNumber = rnd.Next(0, 2);  // 1 and 2 if whole number, 0 if fractional number
    //Console.Write($"checkWholeFractionalNumber = {checkWholeFractionalNumber}");
    if (checkWholeFractionalNumber == 1 || checkWholeFractionalNumber == 2)
        arr[i] = rnd.Next(-20, 20);
    else if(checkWholeFractionalNumber == 0)
        arr[i] = rnd.Next(-20, 20) + Math.Round(rnd.NextDouble(), 2, MidpointRounding.ToEven);

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
    if (arr[i] % 1 == 0 && arr[i] != 0)
    {
        quantityWholeNumber++;
    }
}

Console.Write($"\nSum of negative elements = {Math.Round(sumNegativeElem, 2, MidpointRounding.ToEven)}\n");
Console.Write($"Maximum element = {maxElem}\n");
Console.Write($"Index of maximum element = {indexMaxElem}\n");
Console.Write($"Maximum element by module = {maxAbsElem}\n");
Console.Write($"Sum index of positive element = {sumIndexPositiveElem}\n");
Console.Write($"Quantity if whole number = {quantityWholeNumber}");

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