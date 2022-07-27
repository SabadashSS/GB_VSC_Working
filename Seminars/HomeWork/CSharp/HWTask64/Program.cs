// Задача 64: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""


namespace Sem9Task64
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ведите значение M: ");
            int numberM = Convert.ToInt32(Console.ReadLine());
            Console.Write("ведите значение N: ");
            int numberN = Convert.ToInt32(Console.ReadLine());

            Console.Write("Все натуральные числа от минимального до максимального значения: ");
            GetNumbers(numberM, numberN);
        }
        public static void GetNumbers(int m, int n)
        {
            if (n > m)
            {
                while (m <= n)
                {
                    Console.Write(m + " "); m++;
                }
            }
            else
            {
                while (n <= m)
                {
                    Console.Write(n + " "); n++;
                }
            }
        }

    }
}