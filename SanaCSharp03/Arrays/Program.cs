int IntInput(string text)
{
    bool check = false;
    int val = 0;
    while (!check || val < 1)
    {
        Console.Write(text);
        check = int.TryParse(Console.ReadLine(), out val);
        if (!check || val < 1)
        {
            Console.WriteLine("Incorect input, you must input an integer above 0.");
        }
    }
    return val;
}


double DoubleInputValue(string text)
{
    bool check = false;
    double val = 0;
    while (!check)
    {
        Console.Write(text);
        check = double.TryParse(Console.ReadLine(), out val);
        if (!check)
        {
            Console.WriteLine("Incorect input, you must write double value.");
        }
    }
    return val;
}

int n = IntInput("n = ");
double[] arr = new double[n];

Console.WriteLine();
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = DoubleInputValue($"Value {i} = ");
}

double negativeSum = 0;
double max = Double.MinValue;
int maxIndex = -1;
double moduleMax = -1;
int positiveIndexSum = 0;
int intagerAmount = 0;

Console.WriteLine();
for (int i = 0; i < arr.Length; i++)
{
    double curVal = arr[i];
    //task 4.1
    if (curVal < 0)
    {
        negativeSum += curVal;
    }
    //task 4.2, task 4.3
    if (curVal > max)
    {
        max = curVal;
        maxIndex = i;
    }
    //task 4.4
    double mouduleCurVal = Math.Abs(curVal);
    if (mouduleCurVal > moduleMax)
    {
        moduleMax = mouduleCurVal;
    }
    //task 4.5
    if (curVal > 0)
    {
        positiveIndexSum += i;
    }
    //task 4.6
    if (curVal % 1 == 0)
    {
        intagerAmount++;
    }
}

Console.WriteLine("\nResults of calculating:");
Console.WriteLine($"Sum of negative elements: {negativeSum}");
Console.WriteLine($"Maximum element: {max}");
Console.WriteLine($"Maximum element index: {maxIndex}");
Console.WriteLine($"Maximum element by modulus: {moduleMax}");
Console.WriteLine($"Positive elements` indexes sum: {positiveIndexSum}");
Console.WriteLine($"Intager amount: {intagerAmount}");