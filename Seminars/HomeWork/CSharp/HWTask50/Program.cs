// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

namespace Sem7Task50
{
    class Program
    {
        static void Main(string[] asgs)
        {
            int[,] massive = new int[3, 4];
            FillMatrix(massive);
            PrintMatrix(massive);
            Console.WriteLine();
            Console.WriteLine("Укажите через , позиции элементов в двумерном массиве: ");
            string? position = Console.ReadLine();
            string[] pos = position.Split(',');
            GetArrayElement(massive, pos);
        }

        public static int[,] FillMatrix(int[,] newMassive)
        {
            for (int i = 0; i < newMassive.GetLength(0); i++)
            {
                for (int j = 0; j < newMassive.GetLength(1); j++)
                {
                    newMassive[i, j] = new Random().Next(1, 10);
                }
            }
            return newMassive;
        }

        public static int[,] PrintMatrix(int[,] massive)
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

        public static void GetArrayElement(int[,] matrix, string[] posMassive)
        {
            int row = int.Parse((posMassive[0]).ToString()) - 1;
            int column = int.Parse((posMassive[1]).ToString()) - 1;
            if (row < matrix.GetLength(0) && column < matrix.GetLength(1))
            {
                Console.WriteLine($"Элемент массива на указанной позиции {matrix[row, column]}");
            }
            else
            {
                Console.WriteLine($"Такой позиции не сущетсвует");
            }
        }
    }
}