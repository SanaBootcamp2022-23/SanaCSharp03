// See https://aka.ms/new-console-template for more information
Console.OutputEncoding = System.Text.Encoding.UTF8;

int size, maxElem = 0, absMaxElem = 0, indexSum = 0, wholenumberCounter = 0;
double negativeSum = 0, max = 0, absMax = 0;

Console.Write("Ввеcти розмір масиву");
size = int.Parse(Console.ReadLine());

double[] arr = new double[size];
Console.WriteLine("Ввести числа: ");
for (int i = 0; i < size; i++)
{
    Console.Write($"{i + 1} Введіть число: ");
    arr[i] = double.Parse(Console.ReadLine());
}
for (int i = 0; i < size; i++)
{
   
    if (arr[i] < 0)
        negativeSum += arr[i];
    
    if (arr[i] >= max)
    {
        max = arr[i];
        maxElem = i;
    }
    
    if (Math.Abs(arr[i]) >= absMax)
    {
        absMax = Math.Abs(arr[i]);
        absMaxElem = i;
    }
    
    if (arr[i] > 0)
        indexSum += i;
    
    if (arr[i] % 1 == 0)
        wholenumberCounter++;
}

Console.WriteLine($"Cума від’ємних елементів масиву: {negativeSum};\n" +
    $"Максимальний елемент масиву: {max};\n" +
    $"Індекс максимального елементу масиву: {maxElem};\n" +
    $"Максимальний за модулем елемент масиву: {absMax};\n" +
    $"Сума індексів додатніх елементів: {indexSum};\n" +
    $"Кількість цілих чисел масиву: {wholenumberCounter}");

