int Size;

Console.Write("Введіть розмір масиву: ");
Size = int.Parse(Console.ReadLine());

double[] numbers = new double[Size];

Console.WriteLine("Введіть числа:");
for (int i = 0; i < Size; i++)
{
    Console.Write($"{i + 1}: ");
    numbers[i] = double.Parse(Console.ReadLine());
}

int imax = 0, iabsMax = 0, posIndexSum = 0, intCounter = 0;
double negativeSum = 0, max = numbers[imax], absMax = numbers[iabsMax];

for (int i = 0; i < Size; i++)
{
    if (numbers[i] < 0)
        negativeSum += numbers[i];

    if (numbers[i] >= max)
    {
        max = numbers[i];
        imax = i;
    }

    if (Math.Abs(numbers[i]) >= absMax)
    {
        absMax = Math.Abs(numbers[i]);
        iabsMax = i;
    }

    if (numbers[i] > 0)
        posIndexSum += i;

    if (numbers[i] % 1 == 0)
        intCounter++;
}

Console.WriteLine($"\nСума від'ємних елементів: {negativeSum}\n" +
    $"Максимальний елемент: {max}\n" +
    $"Індекс максимального елементу: {imax}\n" +
    $"Максимальний елемент за модулем: |{numbers[iabsMax]}| = {absMax}\n" +
    $"Сума індексів додатніх елементів: {posIndexSum}\n" +
    $"Кількість цілих чисел: {intCounter}");
