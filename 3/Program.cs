// Задача 38: Задайте массив вещественных чисел. Найдите разницу
// между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] Arrey = new double[10];
for (int i = 0; i < 10; i++)
{
    Arrey[i] = new Random().Next(-10, 11);
}

for (int i = 0; i < 10; i++)
{
    Console.Write($"{Arrey[i]} ");
}
double min = Arrey[0];
double max = Arrey[0];
for(int i=0; i< Arrey.Length; i++)
{
    while (min > Arrey[i])
    {
        min = Arrey[i];
    }
    while (max< Arrey[i]){
        max = Arrey[i];
    }
}


Console.WriteLine($"разница между максимальным и минимальным элементов массива : {max-min}");