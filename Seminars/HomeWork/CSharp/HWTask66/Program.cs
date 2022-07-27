// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


namespace Sem9Task66
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение M: ");
            int numberM = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение N: ");
            int numberN = Convert.ToInt32(Console.ReadLine());

            GetSumNumbers(numberM, numberN);
        }
        public static void GetSumNumbers(int m, int n)
        {
            int sum = 0;
            if (n > m)
            {
                Console.Write($"Сумма всех натуральных числел от {m} до {n}: ");
                while (m <= n)
                {
                    sum = sum + m;
                    m++;
                }
                Console.WriteLine(sum);
            }
            else
            {
                Console.Write($"Сумма всех натуральных числел от {n} до {m}: ");
                while (n <= m)
                {
                    sum = sum + n;
                    n++;
                }
                Console.WriteLine(sum);
            }
        }

    }
}