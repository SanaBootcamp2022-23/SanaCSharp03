uint length, maxIndex = 0, positiveIndexesCount = 0, integersCount = 0;
double negativeSum = 0, max, maxAbs;
Console.Write("Enter array length: ");
while (!uint.TryParse(Console.ReadLine(), out length))
{
    Console.Write("Invalid value, Try again: ");
}

double[] array = new double[length];
Random random = new Random();

for (int i = 0; i < length; i++)
{
    array[i] = Math.Round(random.NextDouble() * (10 - (-10)) + (-10), 1);
}
max = array[maxIndex];
maxAbs = Math.Abs(array[maxIndex]);
for (int i = 0; i < length; i++)
{
    if (array[i] < 0)
    {
        negativeSum += array[i];
    }

    if (array[i] > max)
    {
        max = array[i];
        maxIndex = (uint)i;
    }

    if (Math.Abs(array[i]) > maxAbs)
    {
        maxAbs = Math.Abs(array[i]);
    }

    if (array[i] > 0)
    {
        positiveIndexesCount += (uint)i;

    }

    if (array[i] % 1 == 0)
    {
        integersCount++;
    }
}
Console.WriteLine($"Negative elems sum: {negativeSum}");
Console.WriteLine($"Max elem: {max}");
Console.WriteLine($"Max elem index: {maxIndex}");
Console.WriteLine($"Max Abs elem: {maxAbs}");
Console.WriteLine($"Index count of positive elems: {positiveIndexesCount}");
Console.WriteLine($"Count of integer elements: {integersCount}");