// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

namespace Sem5Task38
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 6;
            int[] array = GetArray(N);
            Console.WriteLine($"Создан массив с {N} элементами: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {GetDiff(GetMax(array), GetMin(array))}");

        }
        public static int[] GetArray(int size)
        {
            int[] arrayX = new int[size];
            for (int index = 0; index < size; index++)
            {
                arrayX[index] = new Random().Next(-10, 11);
            }
            return arrayX;
        }

        public static int GetMax(int[] arrayM)
        {
            int max = arrayM[0];
            for (int index = 0; index < arrayM.Length; index++)
            {
                if (max < arrayM[index])
                {
                    max = arrayM[index];
                }
            }
            return max;
        }
        public static int GetMin(int[] arrayM)
        {
            int min = arrayM[0];
            for (int index = 0; index < arrayM.Length; index++)
            {
                if (min > arrayM[index])
                {
                    min = arrayM[index];
                }
            }
            return min;
        }
        public static int GetDiff(int max, int min)
        {
            return max - min;
        }
    }
}