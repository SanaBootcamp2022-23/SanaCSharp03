using System.Text;
Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;

int N;
Console.Write("Введіть кількість елементів масиву: "); N = int.Parse(Console.ReadLine());
double[] array = new double[N];
double sumneg = 0;
for (int i = 0; i < N; i++)
{
    Console.Write($"array[{i}] = "); array[i] = double.Parse(Console.ReadLine());
    if (array[i] < 0) sumneg += array[i];
}
Console.WriteLine($"Сума негативних елементів = {sumneg}");

double maxel = array[0], indexmaxel = 0, maxmodul = array[0], indexmaxmodul = 0, sumindex = 0, integer = 0;
for (int i = 0; i < N ; i++)
{
    if (maxel < array[i])
    {
        maxel = array[i];
        indexmaxel = i;
    }
    if (Math.Abs(maxmodul) < Math.Abs(array[i]))
    {
        maxmodul = array[i];
        indexmaxmodul = i;
    }
    if (array[i] > 0) sumindex += i;
    if (array[i] % 2 == 0 || array[i] % 1 == 0) integer++;
}
Console.WriteLine($"Максимальний елемент масиву: array[{indexmaxel}] = {maxel}");
Console.WriteLine($"Максимальний елемент за модулем: array[{indexmaxmodul}] = {maxmodul}");
Console.WriteLine($"Сумма індексів додатніх елементів масиву = {sumindex}");
Console.WriteLine($"Кількість цілих чисел масиву = {integer}");