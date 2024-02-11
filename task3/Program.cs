// Задача3: Напишите программу, которая перевернёт одномерный массив 
//  (первый элемент станет последним, второй – предпоследним и т.д.)

using System;
namespace Method
{
    class HW_sem_4_task3
    {
        public static void Main()
        {
            Console.Clear();
            static void CompletionArray(int[] array)
            {
                for (int i = 0; i < array.Length; i++)
                    array[i] = new Random().Next(-1000, 1001);
            }
            static void ReflectArray(int[] array)
            {
                for (int j = 0; j < array.Length / 2; j++)
                {
                    int temp = array[j];
                    array[j] = array[array.Length - j - 1];
                    array[array.Length - j - 1] = temp;
                }
            }
                Console.Write("введите количество элементов массива:  ");
                int n = int.Parse(Console.ReadLine()!);
                int[] numbers = new int[n];
                CompletionArray(numbers);
                Console.WriteLine($"созданный массив: [{string.Join(", ", numbers)}]");
                ReflectArray(numbers);
                Console.WriteLine($"преобразованный массив: [{string.Join(", ", numbers)}]");

        }
           
    }
}
