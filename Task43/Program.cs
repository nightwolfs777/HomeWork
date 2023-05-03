// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите значение b1: ");
double numberB1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение k1: ");
double numberK1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение b2: ");
double numberB2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение k2: ");
double numberK2 = Convert.ToDouble(Console.ReadLine());

double CoordinateX(double numb1, double numk1, double numb2, double numk2)
{
    double x = -(numb1 - numb2) / (numk1 - numk2);
    return x;
}

double CoordinateY(double numb1, double numk1, double numb2, double numk2)
{
    double y = (numk1 * (numb2 - numb1)) / (numk1 - numk2) + numb1;
    return y;
}

double xCoordinate = CoordinateX(numberB1, numberK1, numberB2, numberK2);
double yCoordinate = CoordinateY(numberB1, numberK1, numberB2, numberK2);
Console.Write($"b1 = {numberB1}, k1 = {numberK1}, b2 = {numberB2}, k2 = {numberK2} -> ({xCoordinate}; {yCoordinate})");