// See https://aka.ms/new-console-template for more information
Console.Write("Введіть кількість чисел: ");
int n = 0;
int count = int.Parse(Console.ReadLine());
int[] arr = new int[count];

for (int i = 0; i < count; i++)
{
    Console.WriteLine($"Число {i + 1} = ");
    arr[i] = int.Parse(Console.ReadLine());
    if (arr[i] < 0)
    {
         n += arr[i];
    }
}
Console.WriteLine("Сума відємних елементів масиву: " + n);
