// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2


int[] Arrey = new int[10];
    for (int i = 0; i < 10; i++)
    {
        Arrey[i] = new Random().Next(100, 1000);
    }

    for (int i = 0; i < 10; i++)
    {
        Console.Write($"{Arrey[i]} ");
    }

int Count = 0;
for (int J = 0; J < Arrey.Length; J++)
    if (Arrey[J] % 2 == 0)
    Count = Count + 1;
    

Console.WriteLine($" Количество четных чисел : {Count}");

