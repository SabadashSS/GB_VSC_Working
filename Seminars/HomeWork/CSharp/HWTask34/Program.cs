// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

namespace Sem5Task34
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = new Random().Next(5, 11);
            int[] array = GetArray(N);
            Console.WriteLine($"Создан массив с {N} элементами: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"Количество четных чисел в массиве = {CountEven(array)}");
        }
        public static int[] GetArray(int size)
        {
            int[] arrayX = new int[size];
            for (int index = 0; index < size; index++)
            {
                arrayX[index] = new Random().Next(100, 1000);
            }
            return arrayX;
        }
        public static int CountEven(int[] arrayS)
        {
            int count = 0;
            for (int index = 0; index < arrayS.Length; index++)
            {
                if (arrayS[index] % 2 == 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
