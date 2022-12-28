using System;
using System.Text;
using System.Xml.Linq;

Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;
uint n;
Console.Write("n = ");
while (!uint.TryParse(Console.ReadLine(), out n) || n <= 0)
{
    Console.Write($"Невірно введенно число n, введіть ще раз число n: ");

}
double[] array = new double[n];
double MinusSum = 0, ElementMax = array[0], IndexElementMax = 0, AbsElementMax = array[0], PlusIndexSum = 0, CountIntegersElement = 0;
int SwitchArray;
Console.Write($"Для заповнення масиву вручну введіть 0, для заповнення масиву випадковими числами з діапазона [-999;999], введіть 1: ");
while (!int.TryParse(Console.ReadLine(), out SwitchArray) || SwitchArray<0 || SwitchArray >1)
{
    Console.Write($"Невірно введенно число, спробуйте ще раз");

}
if (SwitchArray == 1)
{
    Random rand = new Random();
    int min = -999, max = 999;
    double temp;
    for (int i = 0; i < n; i++)
    {
        temp = rand.Next(min,max);
        if (Math.Abs(temp) % 2==0)
        {
            array[i] = new Random().Next(min, max);
        }
        else
        {
            array[i] = new Random().NextDouble() + new Random().Next(min, max);
        }
        Console.Write($"array[{i}] = {array[i]}\n"); 
    }
}
else
{
    for (int i = 0; i < n; i++)
    {
        Console.Write($"array[{i}] = ");
        while (!double.TryParse(Console.ReadLine(), out array[i]))
        {
            Console.Write($"Невірно введенно елемент масиву array[{i}], спробуйте ще раз array[{i}]= ");

        }

    }
}



for (int i = 0; i < n; i++)
{

    if (array[i] < 0)
    {
        MinusSum += array[i];
    }
    if (array[i] > ElementMax)
    {
        ElementMax = array[i];
        IndexElementMax = i;

    }
    if (Math.Abs(array[i]) > Math.Abs(AbsElementMax))
    {
        AbsElementMax = array[i];
    }
    if (array[i] > 0)
    {
        PlusIndexSum += i;
    }
    if (array[i] == ((double)((int)array[i])))
    {
        CountIntegersElement++;
    }
}
Console.Write($"Сума від’ємних елементів масиву = {MinusSum}\n" +
    $"Максимальний елемент масиву = {ElementMax}\n" +
    $"Індекс максимального елемент масиву = {IndexElementMax}\n" +
    $"Максимальний за модулем елемент масиву = {AbsElementMax}\n" +
    $"Cума індексів додатних елементів = {PlusIndexSum}\n" +
    $"Кількість цілих чисел у масиві = {CountIntegersElement}");

