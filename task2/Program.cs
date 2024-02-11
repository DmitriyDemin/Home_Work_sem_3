// Задача 2: Задайте массив заполненный случайными трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в массиве.

using System;
namespace Method
{
    class HW_sem_4_task2
    {
        public static void Main()
        {
            Console.Clear();
            static void CompletionArray(int[] array)
            {
                for (int i = 0; i < array.Length; i++)
                    array[i] = new Random().Next(100, 1000);
            }
            int SearchEvenInArray(int[] array)
            {
                int count = 0;
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[j] % 2 == 0)
                        count = count + 1;
                }
                return count;
            }
            Console.Write("введите количество элементов массива:  ");
            int n = int.Parse(Console.ReadLine()!);
            int[] num = new int[n];
            CompletionArray(num);
            Console.WriteLine($"созданный массив: [{string.Join(", ", num)}]");
            Console.WriteLine($"количество четных чисел в массиве:  {SearchEvenInArray(num)}");
        }
    }
}