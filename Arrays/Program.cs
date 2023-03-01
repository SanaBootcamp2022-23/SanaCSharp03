Console.Write("Введіть кількість елементів масиву: ");

int n = int.Parse(Console.ReadLine());
double[] array = new double[n];

Console.WriteLine("Введіть елементи масиву:");
for (int i = 0; i < n; i++)
{
    array[i] = double.Parse(Console.ReadLine());
}

double sumOfNegatives = 0;
double max = double.MinValue;
int maxIndex = -1;
double maxAbs = double.MinValue;
int sumOfPositiveIndices = 0;
int countOfIntegers = 0;

for (int i = 0; i < n; i++)
{
    if (array[i] < 0)
    {
        sumOfNegatives += array[i];
    }
    if (array[i] > max)
    {
        max = array[i];
        maxIndex = i;
    }
    if (Math.Abs(array[i]) > maxAbs)
    {
        maxAbs = Math.Abs(array[i]);
    }
    if (array[i] > 0)
    {
        sumOfPositiveIndices += i;
    }
    if (array[i] == (int)array[i])
    {
        countOfIntegers++;
    }
}

Console.WriteLine("Сума від'ємних: " + sumOfNegatives);
Console.WriteLine("Максимальний елемент: " + max);
Console.Write("Індекс максимального елемента:");
for (int i = 0; i < n; i++)
{
    if (max == array[i])
    {
        Console.Write($" {i}");
    }
}
Console.WriteLine("\nМаксимальний за модулем елемент: " + maxAbs);
Console.WriteLine("Сума індексів додатних елементів: " + sumOfPositiveIndices);
Console.WriteLine("Кількість цілих чисел: " + countOfIntegers);
Console.ReadLine();
