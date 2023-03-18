int n, intc = 0, maxindex = 0, indexsum = 0;
double max, negsum = 0, maxmod;
Console.Write("n:");
n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];
for (int i = 0; i < n; i++)
{
    Console.Write(":");
    arr[i]=Convert.ToInt32(Console.ReadLine());
}

max = arr[0];
maxmod = Double.Abs(arr[0]);
for (int i = 0; i < n; i++)
{
    if (arr[i] < 0) negsum = negsum + arr[i];
    if (arr[i] > max)
    {
        max = arr[i];
        maxindex = i;
    }

    if (Double.Abs(arr[i]) > maxmod) maxmod = arr[i];
    if (arr[i] > 0) indexsum = indexsum + i;
    if (arr[i] - Double.Floor(arr[i]) == 0) intc++;
}
Console.WriteLine($"Сума від'ємних елементів: {negsum}");
Console.WriteLine($"Максимальний елемент масиву: {max}");
Console.WriteLine($"Номер максимального елементу масиву: {maxindex}");
Console.WriteLine($"Максимальний за модулем елемент масиву: {maxmod}");
Console.WriteLine($"Сума індексів додатних елементів: {indexsum}");
Console.WriteLine($"Кількість цілих чисел в масиві: {intc}");
