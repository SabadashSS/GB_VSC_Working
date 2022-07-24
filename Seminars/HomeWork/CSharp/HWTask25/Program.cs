// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


namespace Sem4Task25
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Введите число A: ");
            int numberA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число (степень) B: ");
            int numberB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Результат возведения в степень: {0} ^ {1} = {2}", numberA, numberB, GetPower(numberA, numberB));
        }

        public static int GetPower(int A, int B)
        {
            int result = 1;
            for (int i = 0; i < B; i++)
            {
                result *= A;
            }
            return result;
        }
    }
}