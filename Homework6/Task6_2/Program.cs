/*
Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

double GetNumber(string message)

{
    double result = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (double.TryParse(Console.ReadLine(), out result))
            break;
        else
            Console.WriteLine("Ввели некорректное число. Повторите ввод");
    }
    return result;
}

void GetCoordSolution(double b1, double b2, double k1, double k2)
{
    double x = 0;
    double y = 0;
    if (k1==k2 && b1 == b2)
    {
        Console.WriteLine($"прямые y={k1}*x+{b1} и y={k2}*x+{b2} совпадают");
        return;
    }
    else if (k1==k2 && b1 != b2)
    {
        Console.WriteLine($"прямые y={k1}*x+{b1} и y={k2}*x+{b2} параллельны, точек персечения нет");
        return;
    }
    else
    {
        x = (b1-b2)/(k2-k1);
        y = k1*x+b1;
        Console.WriteLine($"Точкой пересечения прямых y={k1}*x+{b1} и y={k2}*x+{b2} является ({x},{y})");
    }
}

double k1 = GetNumber("Введите коэфициент k1 ");
double b1 = GetNumber("Введите константу b1 ");
double k2 = GetNumber("Введите коэфициент k2 ");
double b2 = GetNumber("Введите константу b1 ");

GetCoordSolution(b1,b2,k1,k2);