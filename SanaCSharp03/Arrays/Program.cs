


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




//максимальний елемент масиву;
//номер (індекс) максимального елемента масиву;
double max = arr[0];
int maxElementIndex = 0;
for (int i = 1; i < arr.Length; i++)
{
    if (arr[i] > max)
    {
        max = arr[i];
        maxElementIndex = i;
    }

}
Console.WriteLine($"The maximum element of the array : ");
Console.WriteLine($"\t{max}");
Console.WriteLine();
Console.WriteLine($"Number (index) of the maximum element of the array : ");
Console.WriteLine($"\t{maxElementIndex}");
Console.WriteLine();


//максимальний за модулем елемент масиву;
double maxAbs = arr[0];
for (int i = 1; i < arr.Length; i++)
{
    if (Math.Abs(arr[i]) > Math.Abs(maxAbs))
    {
        maxAbs = arr[i];

    }
    

}
Console.WriteLine($"The maximum array element by modulus : ");
Console.WriteLine($"\t{maxAbs}");
Console.WriteLine();