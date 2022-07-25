// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка


namespace Sem8Task56
{
    class Program
    {
        static void Main(string[] asgs)
        {
            int[,] massive = new int[5, 4];
            FillMassive(massive);
            Console.WriteLine("Создан массив:");
            PrintMassive(massive);
            int [] arraySum = new int [massive.GetLength(0)];
            Console.WriteLine();
            GetSumRow(massive, arraySum);
            for(int i = 0; i < arraySum.Length; i++)
            {
                Console.WriteLine($" Сумма элементов {i+1} строки = {arraySum[i]}");
            }
            Console.WriteLine();
            Console.WriteLine("Минимальная сумма элементов находится на " 
            + $"{GetMinSum(arraySum)+1} строке ({arraySum[GetMinSum(arraySum)]})");
        }

        public static int[,] FillMassive(int[,] massiveF)
        {
            for (int i = 0; i < massiveF.GetLength(0); i++)
            {
                for (int j = 0; j < massiveF.GetLength(1); j++)
                {
                    massiveF[i, j] = new Random().Next(1, 10);
                }
            }
            return massiveF;
        }

        public static int[,] PrintMassive(int[,] massiveP)
        {
            for (int i = 0; i < massiveP.GetLength(0); i++)
            {
                for (int j = 0; j < massiveP.GetLength(1); j++)
                {
                    Console.Write(massiveP[i, j] + " | ");
                }
                Console.WriteLine();
            }
            return massiveP;
        }

        public static int [] GetSumRow(int [,] massiveMain, int [] arrayS)
        {
            for (int i = 0; i < massiveMain.GetLength(0); i++)
            {
                int resultSumRow = 0;
                for (int j = 0; j < massiveMain.GetLength(1); j++)
                {
                    resultSumRow = resultSumRow + massiveMain[i,j];
                }
                arrayS[i] = resultSumRow;
            }
            return arrayS;
        }
        public static int GetMinSum(int [] array)
        {
            int min = array[0];
            int minPos = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if(min > array[i])
                {
                    min = array[i];
                    minPos = i;
                }
            }
            return minPos;
        }
    }
}