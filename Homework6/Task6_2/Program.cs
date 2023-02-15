/*
Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

int GetNumber(string message)

{
    int result = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result))
            break;
        else
            Console.WriteLine("Ввели некорректное число. Повторите ввод");
    }
    return result;
}

void GetCoordSolution(int b1, int b2, int k1, int k2)
{
    int x = 0;
    int y = 0;
    x = b1-b2/k2-k1;
    y = k1*x+b1;
    Console.WriteLine($"Точкой пересечения прямых y={k1}*x+{b1} и y={k2}*x+{b2} является ({x},{y})");
}

int k1 = GetNumber("Введите коэфициент k1 ");
int b1 = GetNumber("Введите константу b1 ");
int k2 = GetNumber("Введите коэфициент k2 ");
int b2 = GetNumber("Введите константу b1 ");

GetCoordSolution(b1,b2,k1,k2);