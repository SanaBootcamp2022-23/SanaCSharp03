using System.Text;

System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
               System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
customCulture.NumberFormat.NumberDecimalSeparator = ".";
System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;

int length , maxIndex = 0, indexSum = 0, countOfInt = 0;
double negativeSum = 0, max = 0, absMax = 0;

do
{
    Console.Write("Введіть кількість елементів масиву: ");
    length = int.Parse(Console.ReadLine());
}while(length <= 0);

double[] arr;
arr = new double[length];

for (int i = 0; i < length; i++)
{
    Console.Write($"Введіть {i+1} значення  масиву(індекс - [{i}]): ");
    arr[i] = double.Parse(Console.ReadLine());
    if (arr[i] < 0)
    {
        negativeSum+=arr[i];
    }
    if (arr[i] > max)
    {
        max = arr[i];
        maxIndex = i;
    }
    if (Math.Abs(arr[i]) > absMax)
    {
        absMax = Math.Abs(arr[i]);
    }
    if (arr[i]> 0)
    {
        indexSum += i;
    }
    if (arr[i] % 1 == 0)
    {
        countOfInt++;
    }
}

Console.WriteLine($"\nСума від'ємних елементів масиву: {negativeSum}\n" +
                  $"Максимальний елемент масиву: {max}\n" +
                  $"Номер(індекс) максимального елемента масиву: {maxIndex}\n" +
                  $"Максимальний за модулем елемент масиву: {absMax}\n" +
                  $"Сума індексів додатних елементів: {indexSum}\n" +
                  $"Кількість цілих чисел у масиві: {countOfInt}");