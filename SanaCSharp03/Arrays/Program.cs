int N, sumindex = 0, countelemninteger = 0;
double sumnegelement = 0, indexmaxelemt = 0, maxelementofmodule = 0;
Console.Write(" Enter the number of array elements N: ");
N = int.Parse(Console.ReadLine());
if (N < 0)
{
    Console.WriteLine("Error. N < 0");
    return;
}
double[] array = new double[N];
double maxelement = array[0];
for (int i = 0; i < N; i++)
{
    array[i] = double.Parse(Console.ReadLine());
    if (array[i] < 0)
    {
        sumnegelement += array[i];
    }
    if (array[i] > maxelement)
    {
        maxelement = array[i];
        indexmaxelemt = i;
    }
    if (Math.Abs(array[i]) > maxelementofmodule)
    {
        maxelementofmodule = Math.Abs(array[i]);
    }
    if (array[i] > 0)
    {
        sumindex++;
    }
    if (array[i] % 1 == 0)
    {
        countelemninteger++;
    }
}
Console.WriteLine(" Array: ");
for (int i = 0; i < N; i++)
{
    Console.Write($" {array[i]}\t");
}
Console.WriteLine($"\n Summa negative elements array: {sumnegelement}");
Console.WriteLine($"\n The max element is under the index [{indexmaxelemt}] = {maxelement}");
Console.WriteLine($"\n The maximum element of the array module: {maxelementofmodule}");
Console.WriteLine($"\n The sum of positive index: {sumindex}");
Console.WriteLine($"\n Number of integers: {countelemninteger}");