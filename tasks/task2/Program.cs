// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


const int Size = 10;

int[] numbers = CreateRandomArray(Size);
PrintArray(numbers);
int Sum = CalcSum(numbers);
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях равна {Sum}");

void PrintArray(int[] numbers)
{
    foreach (int number in numbers)
        System.Console.Write($"[{string.Join(",", number)}] ");
}

int[] CreateRandomArray(int Size)
{
    int[] numbers = new int[Size];
    for (int i = 0; i < Size; i++)
    {
        numbers[i] = new Random().Next(-100, 100);
    }
    return numbers;
}

int CalcSum(int[] numbers)
{
    int Sum = 0;
    foreach (int number in numbers)
    {
        if (number % 2 != 0)
            Sum += number;
    }
    return Sum;
}
