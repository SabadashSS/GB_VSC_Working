// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

namespace Sem4Task27
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Введите числа для подсчета суммы: ");
            int number = Convert.ToInt32(Console.ReadLine());
            string str = Convert.ToString(number);
            int length = str.Length;
            int[] array = GetArray(number, length);
            Console.WriteLine($"Результат сложения цифр числа {number} = {GetSum(array, length)}");
        }

        public static int[] GetArray(int num, int size)
        {
            int[] arrayX = new int[size];
            for (int index = 0; index < size; index++)
            {
                arrayX[size - 1 - index] = num % 10;
                num = num - arrayX[size - 1 - index];
                num = num / 10;
            }
            return arrayX;
        }
        public static int GetSum(int[] sum, int size)
        {
            int result = 0;
            for (int index = 0; index < size; index++)
            {
                result = result + sum[index];
            }
            return result;
        }
    }
}