// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29


namespace Sem9Task68
{
    class Program
    {

        static void Main(string[] args)
        {
            double result;
            Console.Write("Введите значение m: ");
            double m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение n: ");
            double n = Convert.ToInt32(Console.ReadLine());
            result = GetAkkerman(m, n);
            Console.WriteLine($"Значение функции Аккермана - A({m}, {n}): {result}");
        }
        public static double GetAkkerman(double m, double n)
        {
            if (m == 0) 
            {
                return n + 1;
            }
            if (n == 0) 
            {
                return GetAkkerman(m - 1, 1);
            }
            else 
            {
                return GetAkkerman(m - 1, GetAkkerman(m, n - 1));
            }
        }
    }
}