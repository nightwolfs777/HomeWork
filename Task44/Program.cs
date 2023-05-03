// Не используя рекурсию, выведите первые N чисел Фиббоначчи. Первые 2 числа Фиббоначчи: 0 и 1
// Если N = 5-> 0 1 1 2 3 
// Если N = 3-> 0 1 1  

Console.WriteLine("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] fibonacci = Fibonacci(number);
Console.Write($"N = {number} -> ");
PrintArray(fibonacci);

int[] Fibonacci(int size)
{
    int[] array = new int[size];
    // array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < array.Length; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }
    return array;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]} ");
        else Console.Write($"{arr[i]}");
    }
}