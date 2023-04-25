//  Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите число a: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число c: ");
int number3 = Convert.ToInt32(Console.ReadLine());
int max = number3;

if (number1 > max)
{
    Console.WriteLine($"{number1}, {number2}, {number3} -> {number1}");
}
else if (number2 > max)
{
    Console.WriteLine($"{number1}, {number2}, {number3} -> {number2}");
}
else
{
    Console.WriteLine($"{number1}, {number2}, {number3} -> {number3}");
}
