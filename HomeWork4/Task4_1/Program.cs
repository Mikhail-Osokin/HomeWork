/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/

int GetNumber(string message)

{
    int result = 0;

    while (true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели некорректное число. Повторите ввод");
        }
    }

    return result;
}

int GetDegree(int number1, int number2)
{
    int degree = 1;
    for (int i = 1; i <= number2; i++)
    {
        degree = degree*number1;
    }
return degree;
}

int number1 = GetNumber("Введите число А:");
int number2 = GetNumber("Введите число B:");
int result = GetDegree(number1,number2);
Console.WriteLine($"{number2} степень числа {number1} = {result}");