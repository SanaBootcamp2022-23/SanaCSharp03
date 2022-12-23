Console.WriteLine("Enter n = ");
int n = int.Parse(Console.ReadLine());
int[]arr = new int[n];
var maxEl = 0;
var maxVal = int.MinValue;
var maxAbsVal = int.MinValue;
var countLessThan0 = 0;
var indexMaxEl = 0;
var absMax = 0;
var tmp = 0;
var indexSumMoreThan0 = 0;
var amountOfIntegers = n;      ///// Так як у нас масив типу int отже усі числа будуть цілими
for (var i = 0; i < n; i++)
{
    Console.Write($"element - {i} : ");
    arr[i] = Convert.ToInt32(Console.ReadLine());
   
    if (arr[i] < 0)
    {
        countLessThan0++;
    }
    if (arr[i] > 0)
    {
        indexSumMoreThan0 += i;
    }
   


}
for (var i = 0; i < n; i++)
{
    if (Math.Abs(arr[i]) > maxAbsVal)
    {
        maxAbsVal = Math.Abs(arr[i]);
        tmp = i;
        absMax = maxAbsVal;
        
    }
    if (arr[i] > maxVal)
    {
        maxVal = arr[i];
        indexMaxEl = i;
    }
}
Console.WriteLine("/////////////////////////");
Console.WriteLine($"Max Abs Val = {arr[tmp]}");
Array.Sort(arr);
maxEl = arr[arr.Length-1];  
Console.WriteLine($"Amount of elements less than 0 = {countLessThan0}\nMax Element = {maxEl}\nIndex of Max Element = {indexMaxEl}\nIndex sum of elements more than 0: {indexSumMoreThan0}\nAmount of integers = {amountOfIntegers}");