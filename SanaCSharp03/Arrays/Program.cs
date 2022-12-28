using System.Security.Cryptography;
using System.Text;

namespace Arrays
{
	internal class Program
	{
		static void inputNumber(string variableName, ref int value)
		{
			Console.Write($"Введіть значення змінної {variableName}: ");
			try
			{
				value = int.Parse(Console.ReadLine());
			}
			catch (FormatException)
			{
				Console.WriteLine("Введіть число!");
				inputNumber(variableName, ref value);
			}
		}

		static bool isInt(double value)
		{
			if (value == Convert.ToDouble(Convert.ToInt32(value)))
				return true;
			return false;
		}

		static void Main(string[] args)
		{
			/*В одновимірному масиві, що складається з N дійсних елементів, 
			 * визначити і вивести на екран(в одній консольній програмі):
			суму від’ємних елементів масиву;
			максимальний елемент масиву;
			номер(індекс) максимального елемента масиву;
			максимальний за модулем елемент масиву;
			суму індексів додатних елементів;
			кількість цілих чисел у масиві.*/

			Console.InputEncoding = Encoding.Unicode;
			Console.OutputEncoding = Encoding.Unicode;

			int N = 0;
			inputNumber("N", ref N);

			List<double> arr = new List<double>();
			Console.WriteLine("Введіть значення елементів масиву у стовпчик:");
			double temp = 0;
			for (int i = 0; i < N; i++)
			{

				temp = Convert.ToDouble(Console.ReadLine());
				arr.Add(temp);
			}

			Console.WriteLine("Усі елементи масиву: ");
			for (int i = 0; i < N; i++)
			{
				Console.Write("{0:F2} ", arr[i]);
			}
			Console.WriteLine();


			double sum_of_neg = 0;
			for (int i = 0; i < N; i++)
			{
				// суму від’ємних елементів масиву;
				if (arr[i] < 0)
				{
					sum_of_neg += arr[i];
				}
			}
			Console.WriteLine("Сума від'ємних елементів масиву =  {0}", sum_of_neg);


			double max = arr[0];
			int max_i = 0;
			for (int i = 0; i < N; i++)
			{
				// максимальний елемент масиву;
				// номер(індекс) максимального елемента масиву;
				if (arr[i] > max)
				{
					max = arr[i];
					max_i = i;
				}
			}
			Console.WriteLine("Максимальний елемент масиву = {0}", max);
			Console.WriteLine("Номер(індекс) максимального елемента масиву = {0}", max_i);


			double max_modulo = Math.Abs(arr[0]);
			for (int i = 0; i < N; i++)
			{
				// максимальний за модулем елемент масиву;
				if (Math.Abs(arr[i]) > max_modulo)
				{
					max_modulo = Math.Abs(arr[i]);
				}
			}
			Console.WriteLine("Максимальний за модулем елемент масиву = {0}", max_modulo);



			int sum_of_indexes = 0;
			for (int i = 0; i < N; i++)
			{
				// суму індексів додатних елементів;
				if (arr[i] >= 0)
				{
					sum_of_indexes += i;
				}
			}
			Console.WriteLine("Сума індексів додатних елементів = {0}", sum_of_indexes);


			int count_of_int = 0;
			for (int i = 0; i < N; i++)
			{
				if (isInt(arr[i]))
				{
					count_of_int++;
				}
			}
			Console.WriteLine("Кількість цілих елементів масиву = {0}", count_of_int);


			Console.ReadLine();
		}
	}
}