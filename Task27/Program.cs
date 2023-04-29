// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int len = LenDigital(number);
SumDigital(number, len);


int LenDigital(int num)
{
    int index = 0;
    while (num > 0)
    {
        num = num / 10;
        index++;
    }
    return index;
}

void SumDigital(int num1, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum = sum + num1 % 10;
        num1 = num1 / 10;
    }
    Console.WriteLine(sum);
}