using System.Text;

System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
customCulture.NumberFormat.NumberDecimalSeparator = ".";
System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;

int n = GetSize();
double [] array = new double[n];

FillArray(array);
SumOfNegativeElements(array);
FindMaxElem(array);
FindAbsMaxElem(array);
SumIndecesOfPositiveElements(array);
CountIntegers(array);

Console.ReadKey();


void CountIntegers(double[] arr)
{
    int counter = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 1 == 0)
            counter++;
    }

    Console.WriteLine($"Цілих чисел в масиві: {counter}");
}
void SumIndecesOfPositiveElements(double[] arr)
{
    int sum = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
            sum += i;
    }

    Console.WriteLine($"Сума індексів додатніх елементів: {sum}");
}
void FindAbsMaxElem(double[] arr)
{
    double maxElem = Math.Abs(arr[0]);

    for (int i = 0; i < arr.Length; i++)
    {
        if (Math.Abs(arr[i]) > maxElem)
        {
            maxElem = Math.Abs(arr[i]);
        }
    }

    Console.WriteLine($"Максимальний за модулем елемент масиву: {maxElem}");
}
void FindMaxElem(double[] arr)
{
    double maxElem = arr[0];
    int maxIndex = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > maxElem)
        {
            maxElem = arr[i];
            maxIndex = i;
        }
    }

    Console.WriteLine($"Індекс максимального елемента: {maxIndex}");
    Console.WriteLine($"Максимальний елемент: {maxElem}");
}
void SumOfNegativeElements(double[] arr)
{
    double sum = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0)
            sum += arr[i];
    }

    Console.WriteLine($"Сума від'ємних елементів: {sum}");
}

void FillArray(double[] arr)
{
    for (int i = 0; i < n; i++)
    {
        arr[i] = GetElement(i);
    }
}

double GetElement(int n)
{
    double num;

    do {
        Console.WriteLine($"Введіть {n} елемент масиву:");

        if (!double.TryParse(Console.ReadLine(), out num))
            Console.WriteLine("Помилка!");
        else
            break;

    }while(true);

    return num;
}
int GetSize()
{
    int number;
    do
    {
        Console.WriteLine($"Введіть кількість елементів масиву:");
        if (!int.TryParse(Console.ReadLine(), out number))
            Console.WriteLine($"Помилка у введені кількості елементів! Спробуйте ще раз. \nСпробуйте ще раз:");
        else
        {
            Console.WriteLine($"Кількість елменетів записано!\n");
            break;
        }

    } while (true);
    return number;
}