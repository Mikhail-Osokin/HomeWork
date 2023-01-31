int GetNumbers(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int num = GetNumbers("Введите число от 1 до 7!");
if (num<0||num>7)
{
    Console.WriteLine("Вы не ввели число от 1 до 7!");
}
if (num==6||num==7)
{
    Console.WriteLine("да!");
}
else
{
    Console.WriteLine("нет!");
}