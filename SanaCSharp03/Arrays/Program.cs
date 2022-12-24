int n = Convert.ToInt32(Console.ReadLine());
int negativeSum = 0, sumOfIndexPositivNum = 0, maxElement, indexOfMaxElement = 0, countOfIntegerNum = 0;


Random rand = new Random();

int[] array = new int[n];
for(int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(-10, 10);
}

maxElement = array.Max();
int maxAbsElement = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (array[i] < 0)
    {
        negativeSum += array[i];
    }
    if (array[i] > 0)
    {
        sumOfIndexPositivNum += i;
    }
    if (array[i] == maxElement)
    {
        indexOfMaxElement = i;
    }
    if (array[i] % 1 == 0)
    {
        countOfIntegerNum++;
    }

    if (Math.Abs(array[i])> Math.Abs(maxAbsElement))
    {
        maxAbsElement= array[i];
    }

}

foreach (int value in array)
{
    Console.WriteLine(value);
}
Console.WriteLine($"Cумa від’ємних елементів масиву:{negativeSum}\nMаксимальний елемент масиву:{maxElement}\nHомер (індекс) максимального елемента масиву:{indexOfMaxElement}\nMаксимальний за модулем елемент масиву:{maxAbsElement}\nCумa індексів додатних елементів:{sumOfIndexPositivNum}\nKількість цілих чисел у масиві.:{countOfIntegerNum}");