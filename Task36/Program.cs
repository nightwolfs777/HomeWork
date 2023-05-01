// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечетных позициях
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6]-> 0

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

int SumElementsArr(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 == 1) sum = sum + arr[i];
    }
    return sum;
}

int[] array = CreateArrayRndInt(4, 1, 50);
int sumElementsArr = SumElementsArr(array);
Console.Write("[");
PrintArray(array);
Console.Write("] ");
Console.Write("-> ");
Console.WriteLine(sumElementsArr);