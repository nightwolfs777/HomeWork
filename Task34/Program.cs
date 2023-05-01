﻿// Задайте массив заполненный случайными положительными трехзначными числами. Напишите программу, которая покажет количество четных чисел в массиве.
//[345, 897, 568, 234] -> 2

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

int FindEvenNumber(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
            count++;
    }
    return count;
}


int[] array = CreateArrayRndInt(5, 100, 999);
int findEvenNumber = FindEvenNumber(array);
Console.Write("[");
PrintArray(array);
Console.Write("] ");
Console.Write(" -> ");
Console.WriteLine(findEvenNumber);