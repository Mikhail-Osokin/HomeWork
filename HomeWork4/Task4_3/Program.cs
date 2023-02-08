/*
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/

Console.WriteLine("Введите числа через запятую");
string [] strArray = Console.ReadLine().Split(',');
int [] result = new int[strArray.Length];
for (int i = 0; i < result.Length; i++)
{
    result[i]=int.Parse(strArray[i]);
}
Console.WriteLine(string.Join(',', result));
for (int i = 0; i < result.Length; i++)
{
    Console.Write($"{result[i]} ");
}
