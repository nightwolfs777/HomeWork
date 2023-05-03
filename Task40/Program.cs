// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник со сторонами такой длины
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

Console.WriteLine("Введите сторону A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите сторону B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите сторону C: ");
int numberC = Convert.ToInt32(Console.ReadLine());

bool IsExistTriangle(int numA, int numB, int numC)
{
    return numA < numB + numC && numB < numA + numC && numC < numA + numB;
}

bool existTriangle = IsExistTriangle(numberA, numberB, numberC);
Console.WriteLine(existTriangle ? "Такой труегольник существует" : "Такой труегольник не возможен");