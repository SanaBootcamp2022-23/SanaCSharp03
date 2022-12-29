


double[] arr = new double[2000];
Random random = new Random();
for (int i = 0; i < arr.Length; i++)
{
    if (i % 2 == 0)
        arr[i] = random.NextDouble() * random.Next(-500, 500);
    else arr[i] = random.Next(1, 300);
}



//сумa від’ємних елементів масиву;
double sumNegative = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] < 0)
    {
        sumNegative += arr[i];
    }

}
Console.WriteLine($"The sum of negative array elements : ");
Console.WriteLine($"\t{sumNegative}");
Console.WriteLine();