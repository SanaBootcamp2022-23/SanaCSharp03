// See https://aka.ms/new-console-template for more information
using System.Text;

System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
 System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
customCulture.NumberFormat.NumberDecimalSeparator = ".";
System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

int elementCount, elementPosition;
bool Ok1,Ok2;
int bottomDegre, topDegre;
Random random = new Random();

do
{
    Console.Write("Введіть кількість елементів масиву -> ");
    Ok1 = int.TryParse(Console.ReadLine(), out elementCount);
    if (!Ok1)
    {
        Console.WriteLine("Помилка введення");
    }
} while (!Ok1|| elementCount < 0);


do
{
    Console.Write("Введіть нижню межу значень елементів -> ");
    Ok1 = int.TryParse(Console.ReadLine(), out bottomDegre);
    if (!Ok1)
    {
        Console.WriteLine("Помилка введення");
    }
} while (!Ok1);


do
{
    Console.Write("Введіть верхню межу значень елементів -> ");
    Ok2 = int.TryParse(Console.ReadLine(), out topDegre);
    if (!Ok2)
    {
        Console.WriteLine("Помилка введення");
    }
} while (!Ok1||topDegre<bottomDegre);

double[] array = new double[elementCount];

for(int i = 0; i < array.Length; i++)
{
    array[i] = Convert.ToDouble(random.Next(bottomDegre*100,topDegre*100+1) / 100.0);
    Console.WriteLine(array[i]);
}

double sumNegativeElem = 0, maxElem = array[0], indexMaxElem = 0, maxElemModule = Math.Abs(array[0]), sumIdexPositivElem = 0, countIntegerNumbers = 0;
for (int i = 0; i < array.Length; i++)
{
    if(array[i] < 0)
    {
        sumNegativeElem += array[i];
    }

    if (maxElem < array[i])
    {
        maxElem = array[i];
        indexMaxElem = i;
    }
    if (maxElemModule < Math.Abs(array[i]))
    {
        maxElemModule = array[i];
    }

    if (array[i] > 0)
    {
        sumIdexPositivElem += i;
    }

    if (array[i] % 1 == 0)
    {
        countIntegerNumbers += 1;
    }
}
Console.WriteLine($"Сума від'ємних елементів масиву -> {sumNegativeElem}");
Console.WriteLine($"Максимальний елемент масиву -> {maxElem}");
Console.WriteLine($"Індекс максимального елемента масиву -> {indexMaxElem}");
Console.WriteLine($"Максимальний за модулем елемент масиву -> {maxElemModule}");
Console.WriteLine($"Сума індексів додатних елементів масиву -> {sumIdexPositivElem}");
Console.WriteLine($"Кількість цілих чисел у масиві -> {countIntegerNumbers}");

Console.ReadKey();
