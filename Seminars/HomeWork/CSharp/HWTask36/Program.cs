// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

namespace Sem5Task36
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 4;
            int[] array = GetArray(N);
            Console.WriteLine($"Создан массив с {N} элементами: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"Сумма элементов нечетных индексов = {GetSumOdd(array)}");

        }
        public static int[] GetArray(int size)
        {
            int[] arrayX = new int[size];
            for (int index = 0; index < size; index++)
            {
                arrayX[index] = new Random().Next(-99, 100);
            }
            return arrayX;
        }
        public static int GetSumOdd(int[] arrayS)
        {
            int sum = 0;
            for (int index = 0; index < arrayS.Length; index++)
            {
                if (index % 2 != 0)
                {
                    sum = sum + arrayS[index];
                }
            }
            return sum;
        }
    }
}