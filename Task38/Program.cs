// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
    }
    return arr;
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        double elem = Math.Round(arr[i], 1);
        if (i < arr.Length - 1) Console.Write($"{elem}; ");
        else Console.Write($"{elem}");
    }
}

double MaxNumberArr(double[] arr)
{
    double max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
    }
    return max;
}

double MinNumberArr(double[] arr)
{
    double min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
    }
    return min;
}

double[] array = CreateArrayRndDouble(5, 0, 10);
double maxNumberArr = MaxNumberArr(array);
double minNumberArr = MinNumberArr(array);
double differenceMaxNumberMinNumber = maxNumberArr - minNumberArr;
Console.Write("[");
PrintArray(array);
Console.Write("] ");
Console.Write(" -> ");
Console.WriteLine(Math.Round(differenceMaxNumberMinNumber, 1));