namespace SanaSharp03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of array(N):");
            uint n;
            if (!uint.TryParse(Console.ReadLine(), out n)) ExitWithError();
            Console.Write("Enter the \"1\", if you want input numbers yourself." +
                "\nEnter the \"2\", if you want random generated numbers." +
                "\nEnter: ");
            char choice = '2'; ;
            int[] arr = new int[n];
            if (!char.TryParse(Console.ReadLine(), out choice)) ExitWithError();
            if (choice == '1')
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write($"Enter the {i + 1} number: ");
                    if (!int.TryParse(Console.ReadLine(), out arr[i])) ExitWithError(); ;
                }
            else
                arr = GeneratingArrRandValue(arr);
            SumOfNegNumbers(arr);
            MaxElementOfArr(arr);
            MaxElementOfArrModulo(arr);
            SumOfIndexsOfPosElements(arr);
        }

        static void SumOfNegNumbers(int[] arr)//SubTask 1
        {
            int Sum=0;
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] < 0)
                    Sum+=arr[i];
            Console.WriteLine($"Sum of all negative elements of array = {Sum}");
        }

        static void MaxElementOfArr(int[] arr)//SubTask 2 and 3
        {
            int IndexMaxElemnt = 0;
            for (int i = 1; i < arr.Length; i++)
                if (arr[IndexMaxElemnt] < arr[i])
                    IndexMaxElemnt = i;
            Console.WriteLine($"Index of max element of array = {IndexMaxElemnt}, it have value = {arr[IndexMaxElemnt]}");
        }
        static void MaxElementOfArrModulo(int[] arr)//SubTask 4
        {
            int IndexMaxElemnt = 0;
            for (int i = 1; i < arr.Length; i++)
                if (Math.Abs(arr[IndexMaxElemnt]) < Math.Abs(arr[i]))
                    IndexMaxElemnt = i;
            Console.WriteLine($"Index of max modulo element of array = {IndexMaxElemnt}, it have value = {arr[IndexMaxElemnt]}");
        }
        static void SumOfIndexsOfPosElements(int[] arr)//SubTask 4 and 5
        {
            int Sum = 0, CountOfPosElements=0;
            for (int i = 1; i < arr.Length; i++)
                if (arr[i] > 0)
                {
                    Sum += i;
                    CountOfPosElements++;
                }
            Console.WriteLine($"Sum of positive elements of array = {Sum}." +
                $"\nCount of positive elements of array = {CountOfPosElements}");
        }

        #region Additional functions
        static int[] GeneratingArrRandValue(int[] arr)
        {
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
                arr[i] = rand.Next(-500,500);
            Console.Write("Random ganarated array = ");
            OutputArr(arr);
            return arr;
        }
        static void OutputArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write($"{arr[i]} ");
            Console.Write("\n");
        }
        static void ExitWithError()
        {
            Console.WriteLine("Incorrect value.");
            return;
        }
        #endregion

    }
}