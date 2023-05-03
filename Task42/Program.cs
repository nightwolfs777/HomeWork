// Напишите программу, которая будет преобразововать десятичное число в двоичное.


Console.WriteLine("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int resultBin = DecToBin(number);
Console.WriteLine($"{number} -> {resultBin}");
int DecToBin(int num)
{
    int count = 1;
    int result = 0;
    while (num > 0)
    {
        result += num % 2 * count;
        num /= 2;
        count *= 10;
    }
    return result;
}
