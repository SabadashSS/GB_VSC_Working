// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


namespace CSharpHomeWork
{
    class Sem3Task23
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число:");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] Cubes = GetCube(N);
            Console.Write($"Таблица кубов числа {N}: ");
            for (int i = 0; i < Cubes.Length; i++)
            {
                Console.Write(Cubes[i] + ", ");
            }
        }
        public static int[] GetCube(int n)
        {
            int[] cube = new int[n];
            for (int i = 1; i <= n; i++)
            {
                cube[i - 1] = i * i * i;
            }
            return cube;
        }
    }
}