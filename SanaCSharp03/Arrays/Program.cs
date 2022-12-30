Console.WriteLine("Enter the size of the array");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the elements of the array");
double[] array = new double[size];
for (int i = 0; i < size; i++)
{
    array[i] = Convert.ToDouble(Console.ReadLine());
}

double sumOfNegative = 0.0;
double maxElement = array[0];
int indexOfMaxElement = 0;
double maxAbsElement = array[0];
int sumOfIndexPositiveElements = 0;
int numOfIntNumbers = 0;

for (int i = 0; i < size; i++)
{
    if (array[i] < 0.0)
    {
        sumOfNegative += array[i];
    }

    if (array[i] > maxElement)
    {
        maxElement = array[i];
        indexOfMaxElement = i;
    }

    if (Math.Abs(array[i]) > Math.Abs(maxAbsElement))
    {
        maxAbsElement = array[i];
    }

    if (array[i] > 0.0)
    {
        sumOfIndexPositiveElements += i;
    }

    if (array[i] == ((int)array[i]))
    {
        numOfIntNumbers++;
    }
}

Console.WriteLine($"The sum of negative array elements = {sumOfNegative}");
Console.WriteLine($"The maximum element of the array = {maxElement}");
Console.WriteLine($"Number (index) of the maximum element of the array = {indexOfMaxElement}");
Console.WriteLine($"The maximum element of the array by modulus = {maxAbsElement}");
Console.WriteLine($"Sum of indices of positive elements = {sumOfIndexPositiveElements}");
Console.WriteLine($"the number of integers in the array = {numOfIntNumbers}");