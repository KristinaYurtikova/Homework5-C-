// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Введите количество элементов в массиве: ");
int count = int.Parse(Console.ReadLine()!);

int[] array = new int [count];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100,999);
}
Console.WriteLine("$ [{string.Join ("," array)}]");

int CountEven = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array [i] % 2 == 0)
    {
        CountEven++;
    }
}
Console.WriteLine($"Количество четных элементов в массиве {CountEven}");




