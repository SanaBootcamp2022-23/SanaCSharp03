using System.Text;

Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("Arrays");
int N;
double sumOfNegativeEl = 0, maxEl, indexOfMaxEl = 0, maxByModulus, sumOfIndexPositiveEl = 0, wholeNumbers = 0;

Console.Write("Введіть розмір масиву: ");
N = Convert.ToInt32(Console.ReadLine());

double[] arr = new double[N];
maxEl = arr[0];
maxByModulus = arr[0];

for (int i = 0; i < arr.Length; i++)
{
    Console.Write($"Елемент [{i}]: ");
    arr[i] = Convert.ToDouble(Console.ReadLine());
}

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] < 0)
        sumOfNegativeEl += arr[i];
    else
        sumOfIndexPositiveEl += i;

    if (arr[i] > maxEl)
    {
        maxEl = arr[i];
        indexOfMaxEl = i;
    }

    if (Math.Abs(arr[i]) > Math.Abs(maxByModulus))
        maxByModulus = arr[i];

    if (arr[i] % 1 == 0)
        wholeNumbers++;
}

Console.WriteLine($" Сума від’ємних елементів масиву: {sumOfNegativeEl}");
Console.WriteLine($" Максимальний елемент масиву: {maxEl}");
Console.WriteLine($" Індекс максимального елемента масиву: {indexOfMaxEl}");
Console.WriteLine($" Максимальний за модулем елемент масиву: |{maxByModulus}|");
Console.WriteLine($" Сума індексів додатних елементів: {sumOfIndexPositiveEl}");
Console.WriteLine($" Кількість цілих чисел у масиві: {wholeNumbers}");