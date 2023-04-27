// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (CheckingNumber(number) > 0 || CheckingNumber(number) < 0)
{
    if (Palindrom(number))
    {
        Console.WriteLine($"{number} -> да");
    }
    else
    {
        Console.WriteLine($"{number} -> нет");
    }
}

int CheckingNumber(int num)
{
    if (num >= 10000 && num <= 99999) return num;
    if (num >= -99999 && num <= -10000) return num;
    else
    {
        Console.WriteLine("Введено не верное число!");
    }
    return num;
}

bool Palindrom(int num)
{
    int x1 = num / 10000; // Первая цифра числа
    int x2 = num / 1000 % 10; // Вторая цифра числа
    int x4 = num % 100 / 10; // Четвертая цифра числа
    int x5 = num % 10; // Пятая цифра числа
    if (x1 == x5 && x2 == x4)
    {
        return true;
    }
    return false;
}