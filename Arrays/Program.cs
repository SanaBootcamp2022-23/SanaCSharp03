//This program displays the sum of the negative elements of the array, the maximum element of the array,
//the index number of the maximum element of the array, the maximum element of the array modulo, the sum
//of the indices of the positive elements of the array, and the number of integers in the array

Console.WriteLine("\n\t\t\tHello my dear friend!\n\n" +
                  "\tThis program displays 6 different results of\n" +
                  "\tworking with indexes and array elements\n" +
                  "\tIf you want to see how it works, set the number of array\n" +
                  "\telements by entering any natural number N on the keyboard,\n" +
                  "\tand also set each element of the created array by entering\n" +
                  "\tthe corresponding number of integers in sequence.\n" +
                  "\tIf not, just close the window.\n\n" +
                  "\tComplete the input of the natural number N and each element\n" +
                  "\tof the array by pressing the \"Enter\" key.\n");

int naturalN,
    counterNegElem = 0,
    indexMaxElem = 0,
    indexMaxElemModule = 0,
    sumIndexPositiveElem = 0,
    numberIntegers = 0;
double sumNegativeElements = 0,
       maxElement = 0,
       maxElemModule = 0;

//This cycle does not allow the user to set the number of array elements to zero or a negative number
do
{
    Console.Write("\t\t\tInput natural number N: ");
    naturalN = int.Parse(Console.ReadLine());
    
    if (naturalN <= 0 )
        Console.WriteLine("\n\tThe number of array elements cannot be negative or zero! Please re-enter.");
}
while (naturalN <= 0);

double[] array = new double[naturalN];
Console.WriteLine($"\n\t\tCreated an array of {naturalN} elements.\n");

for (int counter = 0; counter < naturalN; counter++)
{
    Console.Write($"\t\t\tInput {counter} array element: "); ; ;
    array[counter] = double.Parse(Console.ReadLine());
    if (array[counter] < 0)
    {
        sumNegativeElements += array[counter];
        counterNegElem++;
    }
    if (maxElement < array[counter])
    {
        maxElement = array[counter];
        indexMaxElem = counter;
    }
    if (Math.Abs(maxElemModule) < Math.Abs(array[counter]))
    {
        maxElemModule = array[counter];
        indexMaxElemModule = counter;
    }
    if (array[counter] > 0)
        sumIndexPositiveElem += counter;
    if (array[counter] % 1 == 0)
        numberIntegers++;
}

Console.WriteLine($"\n\t\tThe array contains {counterNegElem} negative elements. Their sum is: {sumNegativeElements}.\n");
Console.WriteLine($"\n\t\tThe maximum element of the array is contained in cell number {indexMaxElem}" +
                  $" and is equal to {maxElement}.\n");
Console.WriteLine($"\n\t\tThe maximum element of the array modulo is contained in cell number {indexMaxElemModule}" +
                  $" and is equal to {maxElemModule}.\n");
Console.WriteLine($"\n\t\tThe sum of the indices of positive elements is: {sumIndexPositiveElem}.\n");
Console.WriteLine($"\n\t\tNumber of integers in array: {numberIntegers}.\n");