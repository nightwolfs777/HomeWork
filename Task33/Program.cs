﻿// Задайте массив.Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив[6, 7, 19, 43] -> нет
// 6; массив [6, 7, 19, 43] ->  да

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

bool CheckTheNumber(int num, int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num) return true;
    }
    return false;
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArrayRndInt(4, -9, 9);
Console.Write("[");
PrintArray(array);
Console.Write("]");

bool checkTheNumber = CheckTheNumber(number, array);
Console.WriteLine();
Console.WriteLine(checkTheNumber ? "да" : "нет");

