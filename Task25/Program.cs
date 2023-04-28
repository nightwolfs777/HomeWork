// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int result = Pow(numberA, numberB);
Console.WriteLine($"{numberA}, {numberB} -> {result}");

int Pow(int num1, int num2)
{
    int res = num1;
    for (int i = 1; i < num2; i++)
    {
        res = res * num1;
    }
    return res;
}