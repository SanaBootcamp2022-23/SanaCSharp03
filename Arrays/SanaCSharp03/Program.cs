// See https://aka.ms/new-console-template for more information

int count;
Console.WriteLine("n = ");
count = int.Parse(Console.ReadLine());
int[] array = new int[count];
int summa = 0;
int maxValue = 0;
int index = 0;
int module = 0;
int indexSum = 0;
for (int i = 0; i < count; i++)
{
    array[i] = int.Parse(Console.ReadLine());
    if (array[i] < 0) 
        summa = summa + array[i];
    maxValue = array.Max();
    index = array.ToList().IndexOf(maxValue);
    module = Math.Abs(array[i]);
    module = array.Max();
    array.Select((x, i) => x > 0 ? i : 0).Sum();
    if(array[i] > 0)
    indexSum = indexSum + array.ToList().IndexOf(array[i]);
    array.Where(i => Convert.ToInt32(i) == Convert.ToDouble(i)).Sum();

}
Console.WriteLine(summa);
Console.WriteLine(maxValue);
Console.WriteLine(index);
Console.WriteLine(module);
Console.WriteLine(array.Select((x, i) => x > 0 ? i : 0).Sum());
Console.WriteLine(indexSum);
Console.WriteLine(array.Where(i => Convert.ToInt32(i) == Convert.ToDouble(i)).Sum());