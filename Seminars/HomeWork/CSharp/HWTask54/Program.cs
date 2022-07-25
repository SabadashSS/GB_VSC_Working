// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по возрастанию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8


namespace Sem8Task54
{
    class Program
    {
        static void Main(string[] asgs)
        {
            int[,] massive = new int[3, 4];
            FillMassive(massive);
            PrintMassive(massive);
            GetMassiveSort(massive);
            Console.WriteLine();
            PrintMassive(massive);
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

        public static int[,] GetMassiveSort(int[,] massiveS)
        {
            for (int i = 0; i < massiveS.GetLength(0); i++)
            {
                int min = massiveS[i, 0];
                for (int j = 0; j < massiveS.GetLength(1); j++)
                {
                    int minPos = j;
                    for (int jMatching = j + 1; jMatching < massiveS.GetLength(1); jMatching++)
                    {
                        if (massiveS[i, minPos] > massiveS[i, jMatching])
                        {
                            minPos = jMatching;
                        }
                    }
                    int change = massiveS[i, minPos];
                    massiveS[i, minPos] = massiveS[i, j];
                    massiveS[i, j] = change;
                }
            }
            return massiveS;
        }
    }
}