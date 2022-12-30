Console.OutputEncoding = System.Text.Encoding.Default;

double[] numbers = { -2.5, 3.7, 8.1, -1.3, 0.9, 7.2, -4.6, 5, 7, 13, -28 };
int N = numbers.Length;


double sumNegative = 0;
double max = double.MinValue;
int maxIndex = -1;
double maxAbs = double.MinValue;
int sumPositiveIndex = 0;
int numIntegers = 0;


for (int i = 0; i < N; i++)
{
  
    if (numbers[i] < 0)
    {
        sumNegative += numbers[i];
    }


    if (numbers[i] > max)
    {
        max = numbers[i];
        maxIndex = i;
    }

   
    if (Math.Abs(numbers[i]) > maxAbs)
    {
        maxAbs = Math.Abs(numbers[i]);
    }

   
    if (numbers[i] > 0)
    {
        sumPositiveIndex += i;
    }

    
    if (Math.Abs(numbers[i] - (int)numbers[i]) < double.Epsilon)
    {
        numIntegers++;
    }
}


Console.WriteLine("Сума від’ємних елементів масиву: " + sumNegative);
Console.WriteLine("Максимальний елемент масиву: " + max);
Console.WriteLine("Індекс максимального елемента масиву: " + maxIndex);
Console.WriteLine("максимальний за модулем елемент масиву: " + maxAbs);
Console.WriteLine("Сума індексів додатних елементів: " + sumPositiveIndex);
Console.WriteLine("Кількість цілих чисел у масиві: " + numIntegers);