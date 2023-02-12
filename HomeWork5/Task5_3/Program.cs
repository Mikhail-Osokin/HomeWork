/*
 Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

double [] InitArray()
{
    double [] result = new double [20];
    Random rnd = new Random();
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(0,100);
    }
    return result;
}

void PrintArray(double [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

double DifMaxMinELementsOFArray(double [] array)
{
    double max = array[0];
    double min = array[0];
    double difference = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]<min) 
            min = array[i];
        if (array[i]>max) 
            max = array[i];
    }
    difference = max - min;
    return difference;
}

double [] arr = InitArray();
PrintArray(arr);
double dif = DifMaxMinELementsOFArray(arr);
Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {dif}");