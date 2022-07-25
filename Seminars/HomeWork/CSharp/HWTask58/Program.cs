// Задача 58: Задайте две матрицы. Напишите программу, 
// которая выведет матрицу произведения элементов двух предыдущих матриц.
// Например, заданы 2 массива:
// 1 4 7 2                1 5 8 5
// 5 9 2 3                4 9 4 2
// 8 4 2 4                7 2 2 6
// 5 2 6 7       и        2 3 4 7

// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

namespace Sem8Task58
{
    class Program
    {
        static void Main(string[] asgs)
        {
            int[,] massiveFirst = new int[4, 4];
            int[,] massiveSecond = new int[4, 4];
            FillMassive(massiveFirst);
            FillMassive(massiveSecond);
            Console.WriteLine("Сгенерирован первый массив 4х4: ");
            PrintMassive(massiveFirst);
            Console.WriteLine("Сгенерирован второй массив 4х4: ");
            PrintMassive(massiveSecond);
            int[,] massiveProduct = GetProductMassive(massiveFirst, massiveSecond);
            Console.WriteLine();
            Console.WriteLine("Матрица произведения элементов двух предыдущих массивов: ");
            PrintMassive(massiveProduct);
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

        public static int[,] GetProductMassive(int[,] massive1, int[,] massive2)
        {
            for (int i = 0; i < massive1.GetLength(0); i++)
            {
                for (int j = 0; j < massive1.GetLength(1); j++)
                {
                    massive1[i, j] = massive1[i, j] * massive2[i, j];
                }
            }
            return massive1;
        }
    }
}