// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

using System;
namespace Method
{
    class HW_sem_4_task1
    {
        public static void Main()
        {
            Console.Clear();
            string KeyboardInput()
            {
                Console.Write("введите целое число, для выхода введение 'q':  ");
                string num = (Console.ReadLine()!);
                return num;
            }
            int CalculationSum(string n)
            {
                int Sum = 0;
                for (int i = 0; i < n.Length; i++)
                    Sum = Sum + int.Parse(n[i].ToString());
                // Console.WriteLine($"сумма: {Sum} ");
                return Sum;
            }

            int ConvStrInInt(string n)
            {
                int f;
                if (n.Length == 1)
                {
                    char m = Convert.ToChar(n);
                    f = Convert.ToInt32(m);
                    // Console.WriteLine($"в таблице кодировок: {f} ");
                }
                else
                    f = 0;
                // Console.WriteLine($"в таблице кодировок: {f} ");
                return f;
            }
            while (CalculationSum(KeyboardInput()) % 2 != 0 || ConvStrInInt(KeyboardInput()) != 113)
                KeyboardInput();


        }
    }
}








