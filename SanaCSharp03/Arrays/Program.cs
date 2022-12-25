using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int quatn;
            double x;
            Console.WriteLine("Enter quantity of array:");
            quatn = int.Parse(Console.ReadLine());
            double[] array = new double[quatn];
           
            for (int i = 0; i < quatn; i++)
            {
                x = double.Parse(Console.ReadLine());
                array[i] = x;
            }
            for (int i = 0; i < quatn; i++)
            {
                Console.WriteLine($"array[{i}] = {array[i]}");
            }

            //////Sum negative--------------------
            double sumneg = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    sumneg += array[i];
                }
            }
            Console.WriteLine($"Sum of negative = {sumneg}");

            //////MAX num and index num--------------------
            double max = array[0];
            int index = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    index = i;
                }
            }
            Console.WriteLine($"Max = {max}; Index = {index}");

            //////MAX module--------------------
            double maxM = Math.Abs(array[0]);
            for (int i = 1; i < array.Length; i++)
            {
                if (Math.Abs(array[i]) > maxM)
                {
                    maxM = Math.Abs(array[i]);
                }
            }
            Console.WriteLine($"MaxModule = {maxM}");
            //////SumIndexes--------------------
            double sumInd = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    sumInd += i;
                }
            }
            Console.WriteLine($"Sum indexes = {sumInd}");

            ////integer
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]%1 == 0)
                    count++;
                
            }
            Console.WriteLine($"Count integerces = {count}");
        }
    }
}
