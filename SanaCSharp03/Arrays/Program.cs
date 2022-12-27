// See https://aka.ms/new-console-template for more information
using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {

        // Sum

        int[] myArray = { 33, 2, 4, -10, 77, 99, 43, 12, -53, 59, 12, 1671 };
        float sum = 0;

        for (int i = 0; i < myArray.Length; i++)
        {
            if (myArray[i] < 0)
            {
                sum += myArray[i];
            }
        }
        // maxValue

        int maxValue = myArray[0];
        {
            for (int i = 0; i < myArray.Length; i++)


                if (myArray[i] > maxValue)
                {
                    maxValue = myArray[i];
                }

        }
        // maxIndex

        int maxIndex = 1;
        {
            for (int i = 0; i < myArray.Length; i++)

                if (maxValue <= myArray[i])
                {

                    maxValue = myArray[i];

                    maxIndex = i;
                }

        }

        // maxModule
        double maxModule = 0;
        {
            for (int i = 0; i < myArray.Length; i++)
            {
                if (Math.Abs(myArray[i]) > maxValue)
                    maxValue = myArray[i];
                maxModule = i;
            }

        }

        // indexSum

        int count = 0;
        for (int i = 0; i < myArray.Length; i++)
        {

            if (Math.Abs(myArray[i]) > maxValue)
            {
                maxValue = Math.Abs(myArray[i]);
                count = i;
            }

        }

        int integr = 0;

        for (int i = 0; i < myArray.Length; i++)
        {
            if (myArray[i] % 1 == 0)
            {
                integr++;
            }

        }

        Console.WriteLine("Sum= {0}", sum);
        Console.WriteLine("maxValue= {0}", maxValue);
        Console.WriteLine("maxIndex= {0}", maxIndex);
        Console.WriteLine("Module= {0}", maxModule);
        Console.WriteLine("Index Sum= {0}", count);
        Console.WriteLine("integr= {0}", integr);
        Console.ReadLine();

    }
}

