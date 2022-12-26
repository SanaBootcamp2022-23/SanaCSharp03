using System.Text;

Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;


Console.Write("Введіть довжину масиву: ");
int n;
CheckArrayLength(Console.ReadLine(), out n);

float[] arr = new float[n];

for (int i = 0; i < arr.Length; i++)
{
    Console.Write($"Введіть {i}-й елемент масиву: ");
    CheckFloatValue(Console.ReadLine(), out arr[i]);
}

Console.WriteLine("Масив: ");
for(int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i]+" ");
}

float negSum = 0;
for(int i = 0; i < arr.Length; i++)
{
    if (arr[i] < 0)
    {
        negSum += arr[i];
    }
}
Console.WriteLine($"Сума від'ємних елементів масиву: {negSum}");

float maxEl = arr[0];
int maxElIndex = 0;
for(int i = 1; i < arr.Length; i++)
{
    if (arr[i]> maxEl)
    {
        maxEl = arr[i];
        maxElIndex = i;
    }
}
Console.WriteLine($"Максимальний елемент масиву: {maxEl}");
Console.WriteLine($"Індекс максимального елементу масиву: {maxElIndex}");

float maxElAbs = (float)Math.Abs(arr[0]);
for (int i = 1; i < arr.Length; i++)
{
    if (Math.Abs(arr[i]) > maxElAbs)
    {
        maxElAbs = arr[i];
    }
}
Console.WriteLine($"Максимальний елемент масиву за модулем: {maxElAbs}");

int posElIndexSum = 0;
for (int i = 1; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        posElIndexSum += i;
    }
}
Console.WriteLine($"Сума індексів додатних елементів: {posElIndexSum}");

int countInt = 0;

foreach(float i in arr)
{
    int tmp;
    int.TryParse(i.ToString(), out tmp);
    if ( tmp == i)
    {
        countInt++;
    }
}
Console.WriteLine($"Кількість цілих чисел у масиві: {countInt}");
Console.ReadKey();


void CheckArrayLength(string? s, out int a)
{
    bool fl = false;
    do
    {
        if(!int.TryParse(s, out a) || a <= 0)
        {
            Console.Write("\tПомилка! Невірна довжина масиву!\nВведіть ще раз: ");
            s = Console.ReadLine();
        }
        else
        {
            fl = true;
        }
    } while (!fl);
}

void CheckFloatValue(string? s, out float a)
{
    bool fl = false;
    do
    {
        if (!float.TryParse(s, out a))
        {
            Console.Write("\tПомилка! Некоректне значення!\nВведіть ще раз: ");
            s = Console.ReadLine();
        }
        else
        {
            fl = true;
        }
    } while (!fl);
}
