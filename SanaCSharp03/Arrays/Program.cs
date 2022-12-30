

class Program
{
    static void Main()
    {

        Random random = new Random();
        Console.Write("Array lenght: ");
        int ArrayLenght = Int32.Parse(Console.ReadLine());

        int [] numbers = new int [ArrayLenght];

        for (int i = 0; i < ArrayLenght; i++)
        {
            numbers[i] = random.Next(-100, 100);
            Console.Write(numbers[i] + " ");
        }
        Console.WriteLine();    
        

        

        int sumOfNeg = 0;
        int maxNum = numbers[0];
        int maxNumIndex = 0;
        int maxAbsNum = Math.Abs(numbers[0]);
        int sumIndexOfPositiveNumber = 0;
        int evenCounter = 0;

        for (int j = 0; j < numbers.Length; j++)
        {
            if (numbers[j] < 0)
            {
                sumOfNeg += numbers[j];
            }

            if (maxNum < numbers[j])
            {
                maxNum = numbers[j];
                maxNumIndex = j;
            }

            if (maxAbsNum < Math.Abs(numbers[j]))
                maxAbsNum = Math.Abs(numbers[j]);
            if (numbers[j] > 0)
                sumIndexOfPositiveNumber += j;

            if (numbers[j] % 2 == 0)
                evenCounter++;

        }

        Console.WriteLine("sum of negative numbers: " + sumOfNeg);
        Console.WriteLine("max number: " + maxNum);
        Console.WriteLine("max number index: " + maxNumIndex);
        Console.WriteLine("max absolute number: " + maxAbsNum);
        Console.WriteLine("sum index of positive: " + sumIndexOfPositiveNumber);
        Console.WriteLine("num of even numbers: " + evenCounter);




    }
}