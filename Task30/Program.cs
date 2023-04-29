Console.WriteLine("Введите длину массива: ");
int lenghtArray = Convert.ToInt32(Console.ReadLine());
int[] arr = CreateArray(lenghtArray);
PrintArray(arr);

int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 99);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
