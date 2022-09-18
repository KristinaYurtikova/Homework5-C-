// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

//const int Size = 10;

//int[] array = CreateArray(Size);
//Console.WriteLine();
//int search = int.Parse(Console.ReadLine());

//int [] CreateArray (int [Size]);
//{
 //   int[] numbers = new int [Size];
 //   for (int i = 0; i < numbers.Length; i++)
 //   {
 //       numbers[i] = new Random().Next(100,999);
 //   }
  ///  return numbers;
//}




using System;

    class Program
    {
        static void Main()
        {
            Random myRnd = new Random();// Объявляется генератор случайных чисел.
            int[] a = new int[10];//Объявление целочисленного массива длинной 10.
            Console.WriteLine("Исходный массив:");


            for (int i = 0; i < a.Length; i++)//Цикл заполнения массива.
            {
                a[i] = myRnd.Next(1, 10);//Присвоение случайного числа от 1 до 10 [i]-тому элементу массива.
                Console.Write(a[i] + " ");//Вывод на экран.
            }
            Console.WriteLine("\nРезультат:");


            for (int i = 0; i < a.Length; i++)//Цикл вывода массива.
            {
                if (a[i] % 2 != 0) a[i] = a[i] * 3;//Если элемент массива нечётный, то умножаем его на 3.
                else a[i] = 0;//Иначе присваиваем значение элементу 0.             
                Console.Write(a[i] + " ");
            }
            Console.ReadKey();//Задержка консоли.
        }
    }
Детали на https://studlearn.com/works/details/chyotnye-i-nechyotnye-elementy-massiva-c-867




