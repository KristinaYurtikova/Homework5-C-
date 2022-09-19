// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

const int Size = 10;

int[] numbers = CreateRandomArray(Size);
PrintArray(numbers);
int Max = CalcMax(numbers);
int Min = CalcMin(numbers);
Console.WriteLine($"Максимальный элемент: {Max},  Минимальный элемент: {Min}");
int DiffMaxMin = CalcDiffMaxMin(numbers);
Console.WriteLine($"Разница между максимальным и минимальным элементов массива {DiffMaxMin}");

void PrintArray(int[] numbers)
{
    foreach (int number in numbers)
        System.Console.Write($"[{string.Join(",", numbers)}] ");
}

int[] CreateRandomArray(int Size)
{
    int[] numbers = new int[Size];
    for (int i = 0; i < Size; i++)
    {
        numbers[i] = new Random().Next(-100.0, 100.0);
        ;
    }
    return numbers;
}

int Max = CalcMax(numbers);
{
    int max = int.MinValue;
    foreach (number i in numbers)
    {
        if (i > max)
        {
            max = i;
        }
    }

}


int Min = CalcMin(numbers);
{
    int min = int.MaxValue;
    foreach (number i in numbers)
    {
        if (i < min)
        {
            min = i;
        }
    }
    return min;
}



