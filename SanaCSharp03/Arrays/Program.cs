
int[] Array(int n, int min, int max)
{
    int[] Array = new int[n];
    Random Rand = new Random();

    for (int i = 0; i < Array.Length; i++)
        Array[i] = (int)(Rand.NextDouble() * (max - min) + min);

    return Array;
}


int n;

do
{
    Console.Write($"Введiть n (n>=1): ");
    if (int.TryParse(Console.ReadLine(), out n) && n >= 1)
        break;
    else
    {
        Console.WriteLine("Невiрне значення n!");
        Console.Write("Введiть повторно n: ");
    }
} while (!int.TryParse(Console.ReadLine(), out n) && !(n >= 1));


Console.WriteLine($"\nЗгенеровано {n} елементiв масиву: ");
int[] Arr = Array(n, -20, 20);
for (int i = 0; i < Arr.Length; i++)
    Console.Write(Arr[i] + "\t");


int NegativeSum = 0;
for (int i = 0; i < Arr.Length; i++)
    if (Arr[i] < 0)
        NegativeSum += Arr[i];

Console.WriteLine($"\n1) Сума вiд'ємних елементiв масиву: {NegativeSum}");

int MaxInArray = Arr[0];
for (int i = 0; i < Arr.Length; i++)
    if (Arr[i] > MaxInArray)
        MaxInArray = Arr[i];

Console.WriteLine($"\n2) Максимальний елемент масиву: {MaxInArray}");

int MaxValueIndex = 0;
MaxInArray = Arr[0];
for (int i = 0; i < Arr.Length; i++)
    if (Arr[i] > MaxInArray)
    {
        MaxValueIndex = i;
        MaxInArray = Arr[i];
    }

Console.WriteLine($"\n3) Iндекс максимального елемента масиву: {MaxValueIndex}");

int AbsoluteMaxValue = Math.Abs(Arr[0]);
for (int i = 0; i < Arr.Length; i++)
    if (Math.Abs(Arr[i]) > AbsoluteMaxValue)
        AbsoluteMaxValue = Math.Abs(Arr[i]);

Console.WriteLine($"\n4) Максимальний за модулем елемент масиву: {AbsoluteMaxValue}");

int PositiveValuesIndexSum = 0;
for (int i = 0; i < Arr.Length; i++)
    if (Arr[i] > 0)
        PositiveValuesIndexSum += i;

Console.WriteLine($"\n5) Сума iндексiв додатнiх елементiв: {PositiveValuesIndexSum}");

int CountOfIntegers = 0;
for (int i = 0; i < Arr.Length; i++)
    if (Arr[i] == 0 || Arr[i] % (int)Arr[i] == 0)
        CountOfIntegers++;

Console.WriteLine($"\n5) Кiлькiсть цiлих чисел у масивi: {CountOfIntegers}");
