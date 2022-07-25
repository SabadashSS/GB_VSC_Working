// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

namespace Sem7Task47
{
    class Program
    {
        static void Main(string[] asgs)
        {
            double[,] massive = new double[3, 4];
            Console.WriteLine("Сгенерирован пустой массив:");
            PrintMatrix(massive);
            Console.WriteLine();
            Console.WriteLine("Массив заполнен случайными вещественными числами:");
            FillMatrix(massive);
            PrintMatrix(massive);
        }

        public static double[,] FillMatrix(double[,] massiveAdd)
        {
            for (int i = 0; i < massiveAdd.GetLength(0); i++)
            {
                for (int j = 0; j < massiveAdd.GetLength(1); j++)
                {
                    massiveAdd[i, j] = new Random().Next(-99, 100);
                    massiveAdd[i, j] = massiveAdd[i, j] / 10;
                }
            }
            return massiveAdd;
        }

        public static double[,] PrintMatrix(double[,] massive)
        {
            for (int i = 0; i < massive.GetLength(0); i++)
            {
                for (int j = 0; j < massive.GetLength(1); j++)
                {
                    Console.Write(massive[i, j] + " | ");
                }
                Console.WriteLine();
            }
            return massive;
        }
    }
}