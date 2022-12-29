using System.Text;

Console.OutputEncoding = Encoding.UTF8;

int N, maxElementIndex = 0, positiveElementsIndexSum = 0, integersNumber = 0;
double maxElement, absMaxElement, negativeElementsSum = 0;

Console.Write("Розмір масиву: ");
N = int.Parse(Console.ReadLine());

double[] arr = new double[N];

for(int i = 0; i < arr.Length; i++)
{
    Console.Write("Елемент " + i + ": ");
    arr[i] = double.Parse(Console.ReadLine());
}

maxElement = arr[0];
absMaxElement = arr[0];

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] < 0)
        negativeElementsSum += arr[i];
    else
        positiveElementsIndexSum += i;

    if (arr[i] > maxElement)
    {
        maxElement = arr[i];
        maxElementIndex = i;
    }

    if (Math.Abs(arr[i]) > Math.Abs(absMaxElement))
        absMaxElement = arr[i];

    if (arr[i] % 1 == 0)
        integersNumber++;
}

Console.WriteLine("\nСума від’ємних елементів: " + negativeElementsSum);
Console.WriteLine("Максимальний елемент: " + maxElement);
Console.WriteLine("Індекс максимального елемента: " + maxElementIndex);
Console.WriteLine("Максимальний за модулем елемент: " + absMaxElement);
Console.WriteLine("Сума індексів додатних елементів: " + positiveElementsIndexSum);
Console.WriteLine("Кількість цілих чисел: " + integersNumber);