// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


namespace Sem7Task52
{
    class Program
    {
        static void Main(string[] asgs)
        {
            int[,] matrix = new int[3, 4];
            FillMatrix(matrix);
            PrintMatrix(matrix);
            Console.WriteLine();
            GetColumnAverage(matrix);
        }

        public static int[,] FillMatrix(int[,] matrixNew)
        {
            for (int i = 0; i < matrixNew.GetLength(0); i++)
            {
                for (int j = 0; j < matrixNew.GetLength(1); j++)
                {
                    matrixNew[i, j] = new Random().Next(1, 10);
                }
            }
            return matrixNew;
        }

        public static int[,] PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " | ");
                }
                Console.WriteLine();
            }
            return matrix;
        }

        public static void GetColumnAverage(int[,] matrix)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                double sum = 0;
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    sum = sum + matrix[i, j];
                }
                double average = Math.Round(sum / matrix.GetLength(0), 1);
                Console.WriteLine($"Среднее арифметическое {j + 1} столбца: {average}");
            }
        }
    }
}
