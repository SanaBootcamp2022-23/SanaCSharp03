using static System.Math;
Console.WriteLine("Enter amount of elements of array");

int amount = int.Parse(Console.ReadLine());
double[]arr=new double[amount];

for(int i=0;i<amount; i++)  
{
    Console.WriteLine("Enter {0} element", i);
    double x =double.Parse(Console.ReadLine());
    arr[i] = x;
}

Console.Write("arr { ");
for (int i = 0; i < amount; i++)
{
    Console.Write("{0} ", arr[i]);
}
Console.Write("}");

double summ_neg = 0;
double max_el = 0;
int ind_max_el = 0;
double form_max_el = 0;
double ind_pos_summ = 0;
int integer_amount = 0;

for (int i = 0; i < amount; i++)
{
    if (arr[i] < 0)
    {
        summ_neg+=arr[i];
    }

    if (arr[i] > max_el)
    {
        max_el= arr[i];
        ind_max_el= i;
    }

    if (Abs(arr[i]) > form_max_el)
    {
        form_max_el= Abs(arr[i]);
    }

    if (arr[i] > 0)
    {
        ind_pos_summ += i;
    }
    if (Convert.ToInt32(arr[i]) == arr[i])
    {
        integer_amount++;
    }
}
Console.WriteLine("");
Console.WriteLine("Summ of negative elements of array = {0}", summ_neg);
Console.WriteLine("Max element = {0}", max_el);
Console.WriteLine("Index of max element {0}", ind_max_el);
Console.WriteLine("The maximum array element by modulus {0}", form_max_el);
Console.WriteLine("Summ of index pos elements {0}", ind_pos_summ);
Console.WriteLine("Integer amount {0}", integer_amount);


