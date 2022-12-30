using static System.Math;

double [] numbers = { 0.5, 2.5, 3, 4, 5,-2.5,-4,-6,-7.5 };
double sum_of_heg=0, max = numbers[0], max_ind = 0, max_modul = numbers[0], sum_of_positive_indx = 0;
int amount_of_integers = 0;
for (int i = 0; i < numbers.Length; i++)
{
    Console.Write($"{numbers[i]}\t");
    if(numbers[i]<0)
    {
        sum_of_heg += numbers[i];
    }

    if (numbers[i] > max)
    {
        max = numbers[i];
        max_ind = i;
    }

    if (Abs(numbers[i]) > Abs(max))
    {
        max_modul = numbers[i];    
    }

    if (numbers[i] > 0)
    {
        sum_of_positive_indx += i;
    }
    if (Convert.ToInt32(numbers[i]) == Convert.ToDouble(numbers[i])) { amount_of_integers++; }
}

Console.WriteLine($"\n\nThe sum of the negative elements = {sum_of_heg}");
Console.WriteLine($"Max element has value {max} and index {max_ind}");
Console.WriteLine($"Max element (with absolute value) = {max_modul}");
Console.WriteLine($"The sum of index of the positive elements = {sum_of_positive_indx}");
Console.WriteLine($"Amount of intagers = {amount_of_integers}");
