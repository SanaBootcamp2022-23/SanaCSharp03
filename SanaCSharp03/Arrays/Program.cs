using System.Text;

Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;

int N;
Console.WriteLine("Введіть кількість дійсних елементів N = ");

N = int.Parse(Console.ReadLine());

if (N <= 0)
{
    while (N <= 0)
    {
        Console.WriteLine("Ви ввели неправильне число. N має бути більшим нуля. Спробуйте ще раз");
        N = int.Parse(Console.ReadLine());
    }
} 
double[] arrayN = new double[N];
double sumNegativeNumbers = 0, maxElementArr = arrayN[0], indexMaxElement = 0, moduleMaxElement = Math.Abs(arrayN[0]), 
    sumIndexPositiveElements = 0, countIntNumbers = 0;

for (int i = 0; i < N; i++)
{
    Console.WriteLine($"Введіть число масиву {i}");
    arrayN[i] = double.Parse(Console.ReadLine());
    if (arrayN[i] < 0)
    {
        sumNegativeNumbers += arrayN[i];
    }
    if(arrayN[i] > maxElementArr)
    {
        maxElementArr = arrayN[i];
        indexMaxElement = i;
    }
    if (Math.Abs(arrayN[i]) > Math.Abs(moduleMaxElement))
    {
        moduleMaxElement = Math.Abs(arrayN[i]);
    }
    if (arrayN[i] >= 1)
    {
        sumIndexPositiveElements += i;
    }
    if (arrayN[i] % 1 == 0 && arrayN[i] != 0)
    {
        countIntNumbers++;
    }
}

Console.WriteLine($"Сума від’ємних елементів масиву = {sumNegativeNumbers}");
Console.WriteLine($"Максимальний елемент масиву = {maxElementArr}");
Console.WriteLine($"Номер (індекс) максимального елемента масиву = {indexMaxElement}");
Console.WriteLine($"Максимальний за модулем елемент масиву = {moduleMaxElement}");
Console.WriteLine($"Сума індексів додатних елементів = {sumIndexPositiveElements}");
Console.WriteLine($"Кількість цілих чисел у масиві = {countIntNumbers}");