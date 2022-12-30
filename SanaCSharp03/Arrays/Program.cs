int N, summa = 0, indexmax = 0, index, whole = 0;
double Negative = 0, max = 0, Abs = 0;

Console.WriteLine("Введіть довжину масиву:");
N = int.Parse(Console.ReadLine());

double[] arr = new double[N];

for (int i = 0; i < N; i++)
{
    Console.Write("Введіть {0} елемент масиву: ", i);
    arr[i] = double.Parse(Console.ReadLine());
}

for (int i = 0; i < N; i++)
{ 
    if (arr[i] < 0)
    {
        Negative += arr[i];
    }

    if (arr[i] > max)
    {
        max = arr[i];
        indexmax = i;
    }

    if (Math.Abs(arr[i]) > Abs)
    {
        Abs = Math.Abs(arr[i]);
    }

    if (arr[i] > 0)
    {
        summa += i;
    }

    if (arr[i] % 1 == 0)
    {
        whole++;
    }
}

    Console.WriteLine("\nСума від'ємних елементів масив: {0}", Negative);
    Console.WriteLine("Максимальний елемент масиву: {0}", max);
    Console.WriteLine("Індекс максимального елементу масиву: {0}", indexmax);
    Console.WriteLine("Максимальний за модулем елемент масиву: {0}", Abs);
    Console.WriteLine("Cума індексів додатніх елементі: {0}", summa);
    Console.WriteLine("Кількість цілих чисел у масиві: {0}", whole);
