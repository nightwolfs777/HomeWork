// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру, обозначающую день недели: ");
int number = Convert.ToInt32(Console.ReadLine());

bool IsWeekend(int number)
{
    if (number > 5)
    {
        return true;
    }
    return false;
}

bool GetWeekend(int week)
{
    if (week > 0 && week <= 7)
    {
        return true;
    }
    Console.WriteLine("Это не день недели");
    return false;
}

if (GetWeekend(number))
{
    if (IsWeekend(number))
    {
        Console.WriteLine("Выходной");
    }
    else
    {
        Console.WriteLine("Рабочий день");
    }
}