/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
Console.WriteLine("Введите число A!");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B!");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число С!");
int C = Convert.ToInt32(Console.ReadLine());
int max = A;
if (B>max)
{
    max = B;
}
if (C>max)
{
    max = C;
}
Console.WriteLine($"Максимальное из трех чисел = {max}");
