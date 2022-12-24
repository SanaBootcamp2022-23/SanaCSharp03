var array = new List<double>();

Console.WriteLine($"Enter elements of array one buy one pressing enter,\n"
    + "leave field empty and press enter to finish");

while (true)
{
    double num;
    Console.Write($"Enter element number {array.Count + 1} -> ");
    var input = Console.ReadLine();
    if (!double.TryParse(input, out num))
    {
        if (string.IsNullOrEmpty(input))
        {
            break;
        }
        Console.WriteLine("Incorrect value");
        continue;
    }
    array.Add(num);
 }

double sumOfNegative = 0;
foreach (double num in array)
{
    if(num < 0)
    {
        sumOfNegative += num;
    }
}
Console.WriteLine($"Sum of negative elements is {sumOfNegative}");


double maxValue = array[0];
int maxValueIndex = 0;
for (int i = 1; i < array.Count; i++)
{
    if (array[i] > maxValue)
    {
        maxValue = array[i];
        maxValueIndex = i;
    }
}
Console.WriteLine($"Maximum element is {maxValue}");

Console.WriteLine($"Maximum element index is {maxValueIndex + 1}");

double maxAbsValue = 0;
for (int i = 0; i < array.Count; i++)
{
    if (Math.Abs(array[i]) > Math.Abs(maxAbsValue))
    {
        maxAbsValue = array[i];
    }
}
Console.WriteLine($"Maximum element by absolute value is {maxAbsValue}");

int sumOfPositiveValuesIndexes = 0;
for (int i = 0; i < array.Count; i++)
{
    if (array[i] > 0)
    {
        sumOfPositiveValuesIndexes += i;
    }
}
Console.WriteLine($"Sum of positive elements indexes is {sumOfPositiveValuesIndexes}");