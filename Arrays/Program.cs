
Random rand = new Random();
int n, sumotr = 0, max, indmax = 0, sumindex = 0, maxmodul = 0;
n = int.Parse(Console.ReadLine());

int[] arr = new int[n];
for (int x = 0; x < n; x++)
{
    arr[x] = rand.Next(-10 ,10);
    Console.Write("  {0}", arr[x]);
}
max = arr[0];
Console.WriteLine();
for (int i = 0; i < n; i++)
{
    if (arr[i] < 0)
    {
        sumotr += arr[i];
    }
    else if (arr[i] != 0)
    {
        sumindex += i; 
    }
    if (arr[i] > max)
    {
        max = arr[i];
        indmax = i + 1;
    }
    if (Math.Abs(arr[i]) > max)
    {
        maxmodul = arr[i];
    }
}
Console.WriteLine("Cума від'ємних елементів масиву = {0}", sumotr);
Console.WriteLine("Максимальний елемент масиву = {0}", max);
Console.WriteLine("Індекс максимального елементу масиву = {0}", indmax);
Console.WriteLine("Максимальний елемент за модулем = {0}", maxmodul);
Console.WriteLine("Сума індексів додатніх елементів = {0}", sumindex);