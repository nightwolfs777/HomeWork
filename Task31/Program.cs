// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9,9]. Найдите сумму отрицательных и положительных элементов массива.
// 1.Задаем массив из 12 элементов
// 2.Заполненный случайными числами из промежутка [-9,9].
// 3.Найдите сумму отрицательных и положительных элементов массива.

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
}

int SumPositiveElements(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) sum = sum + arr[i];
    }
    return sum;
}

int SumNegativeElements(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0) sum = sum + arr[i];
    }
    return sum;
}
int[] array = CreateArrayRndInt(12, -9, 9);
Console.Write("[");
PrintArray(array);
Console.Write("]");
Console.WriteLine();
int sumPositiveElem = SumPositiveElements(array);
int sumNegativeElem = SumNegativeElements(array);
Console.WriteLine($"Суммма положительных элементов равна {sumPositiveElem}");
Console.WriteLine($"Суммма отрицательных элементов равна {sumNegativeElem}");
