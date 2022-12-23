using System.Text;
Console.OutputEncoding = UTF8Encoding.UTF8;

System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
customCulture.NumberFormat.NumberDecimalSeparator = ".";
System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

int size, maxElement = 0, absMaxElement = 0, indexSum = 0, wholenumberCounter = 0;
double negativeSum = 0, max = 0, absMax = 0;

Console.Write("Введіть розмір масиву: ");
size = int.Parse(Console.ReadLine());

double[] arr = new double[size];
Console.WriteLine("Введіть числа");
for (int i = 0; i < size; i++)
{
    Console.Write($"{i+1} Введіть число: ");
    arr[i] = double.Parse(Console.ReadLine());
}
for (int i = 0;i< size; i++)
{
    //1
    if (arr[i] < 0)
        negativeSum += arr[i];
    //2+3
    if (arr[i] >= max)
    {
        max = arr[i];
        maxElement = i;
    }
    //4
    if (Math.Abs(arr[i]) >= absMax)
    {
        absMax = Math.Abs(arr[i]);
        absMaxElement = i;
    }
    //5
    if (arr[i] > 0)
        indexSum += i;
    //6
    if (arr[i] % 1 == 0)
        wholenumberCounter++;
}

Console.WriteLine($"Cума від’ємних елементів масиву: {negativeSum};\n" +
    $"Максимальний елемент масиву: {max};\n" +
    $"Індекс максимального елементу масиву: {maxElement};\n" +
    $"Максимальний за модулем елемент масиву: {absMax};\n" +
    $"Сума індексів додатніх елементів: {indexSum};\n" +
    $"Кількість цілих чисел масиву: {wholenumberCounter}");