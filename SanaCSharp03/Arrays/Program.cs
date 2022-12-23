
Console.Write("Enter count the array: ");
int count = Convert.ToInt32(Console.ReadLine());
double[] array = new double[count];
double summMinusElement = 0;
double maxElementArray = 0;
double maxElementArrayAbs = 0;
double summPlusIndex = 0;
int indexMaxElementArray = 0;
int countNumber = 0;
for (int i = 0; i < count; i++)
{
    double number = double.Parse(Console.ReadLine());
    if (number < 0)
    {
        summMinusElement += number;
    }

    if (number > maxElementArray)
    {
        maxElementArray = number;
        indexMaxElementArray = i;
    }

    if (Math.Abs(number) > Math.Abs(maxElementArrayAbs))
    {
        maxElementArrayAbs = number;
    }

    if (number > 0)
    {
        summPlusIndex += i;
    }

    if (number % 1 == 0)
    {
        countNumber++;
    }
}
Console.WriteLine($"сумa вiд’ємних елементiв масиву: {summMinusElement}\n" +
                  $"максимальний елемент масиву: {maxElementArray}\n" +
                  $"номер максимального елемента масиву: {indexMaxElementArray}\n" +
                  $"максимальний за модулем елемент масиву: {maxElementArrayAbs}\n" +
                  $"суму iндексiв додатних елементiв: {summPlusIndex}\n" +
                  $"кiлькiсть цiлих чисел у масивi: {countNumber}");
