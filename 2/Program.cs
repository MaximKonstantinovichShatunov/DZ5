// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0
int summa= 0;
int[] Arrey = new int[10];
for (int i = 0; i < 10; i++)
{
    Arrey[i] = new Random().Next(-10, 11);
}

for (int i = 0; i < 10; i++)
{
    Console.Write($"{Arrey[i]} ");
}
for (int i = 1; i < Arrey.Length; i=i+2)
{
    summa+= Arrey[i];
}
Console.WriteLine($"Сумма чисел с нечетными индексами: {summa}");