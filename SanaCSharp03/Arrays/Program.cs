using System.Runtime.Serialization.Formatters;

int n;

Console.WriteLine("Введiть розмiр масиву: ");
while(!Int32.TryParse(Console.ReadLine(),out n))
{
    Console.WriteLine("Невiрно введено число! Спробуйте ще раз");
}

double[] arr = new double[n];

for (int i = 0; i < n; i++)
{
    Console.WriteLine("Введiть число: ");
     while(!Double.TryParse(Console.ReadLine(),out arr[i]))
     {
        Console.WriteLine("Невiрно введено число! Спробуйте ще раз");
     }
}


// task 1
double sum = 0;

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] < 0)
    {
        sum += arr[i];
    }
}

Console.WriteLine($"Сума вiд'ємних елементiв масиву : {sum}");


// task 2-4
double max = double.MinValue;
double max_by_module = double.MinValue;
int index = 0;

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] >= max)
    {
        max = arr[i];
        index = i;
    }

    if (Math.Abs(arr[i]) >= max_by_module)
    {
        max_by_module = Math.Abs(arr[i]);
    }
}

Console.WriteLine($"Максимальний елемент масиву : {max}");
Console.WriteLine($"Iндекс максимального елементу : {index}");
Console.WriteLine($"Максимальний за модулем елемент масиву : {max_by_module}");


// task 5
int sum_of_index = 0;

for (int i = 0; i < arr.Length; i++)
{
   if (arr[i] > 0)
    {
        sum_of_index += i;
    }
}

Console.WriteLine($"Сума iндексiв додатнiх елементiв : {sum_of_index}");


// task 6
int count = 0;

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] % 1 == 0)
    {
        count++;
    }
}

Console.WriteLine($"Кiлькiсть цiлих чисел у масивi : {count}");
