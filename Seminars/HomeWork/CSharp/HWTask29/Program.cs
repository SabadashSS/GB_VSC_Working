// Задача 29: Напишите программу, которая задаёт случайный массив случайного размера (от 5 до 10) 
// элементов (значение элементов от 1 до 40) и выводит на экран массив квадратов этих чисел.
// 1, 2, 5, 7, 19 -> [2, 4, 25, 49, 361]
// 6, 1, 33 -> [36, 1, 1089]

namespace Sem4Task29
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
            int[] squares = GetSquares(array);
            Console.WriteLine();
            Console.WriteLine($"Таблица квадратов созданного массива:");
            for (int i = 0; i < squares.Length; i++)
            {
                Console.Write(squares[i] + " ");
            }
        }
        public static int[] GetArray(int size)
        {
            int[] arrayX = new int[size];
            for (int index = 0; index < size; index++)
            {
                arrayX[index] = new Random().Next(1, 41);
            }
            return arrayX;
        }
        public static int[] GetSquares(int[] arrayS)
        {
            for (int index = 1; index <= arrayS.Length; index++)
            {
                arrayS[index - 1] = arrayS[index - 1] * arrayS[index - 1];
            }
            return arrayS;
        }
    }
}
