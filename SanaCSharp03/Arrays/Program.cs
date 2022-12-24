using System.Text;
Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

Console.Write("Введіть натуральне число N - кількість елементів масиву: ");
int N = int.Parse(Console.ReadLine());
if (N < 0)
{
    Console.Write("Помилка! Введіть натуральне число");
    return;
}
double[] array = new double[N];
for (int i = 0; i < N; i++)
{
    Console.Write($"array[{i}]: ");
    array[i] = double.Parse(Console.ReadLine());
}
double sumNegativeNumber = 0;
double maxElem = -10000, minElem = 10000;
int indexMaxElem = 0, indexMinElem = 0, sumIndexPositiveElem = 0, countInteger = 0;
for (int i = 0; i < N; i++)
{
    if (array[i] < 0)
        sumNegativeNumber += array[i];
    if (array[i] > maxElem)
    {
        maxElem = array[i];
        indexMaxElem = i;
    }
    if (array[i] < minElem)
    {
        minElem = array[i];
        indexMinElem = i;
    }
    if (array[i] > 0)
        sumIndexPositiveElem += i;
    if (array[i] == Math.Floor(array[i]))
        countInteger++;
}
double maxAbsElem = Math.Max(maxElem, Math.Abs(minElem));
Console.Write($"Сума від'ємних чисел: {sumNegativeNumber}\nМаксимальний елемент: {maxElem}\n" +
    $"Індекс максимального елементу: {indexMaxElem}\nМаксимальний за модулем: {maxAbsElem}\n" +
    $"Сума індексів додатніх елементів: {sumIndexPositiveElem}\n" +
    $"Кількість цілих чисел в масиві: {countInteger}");


