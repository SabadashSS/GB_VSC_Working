// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N. (не включая N)
// 5 -> 2, 4
// 8 -> 2, 4, 6

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Введите число N");
            int number = Convert.ToInt32(Console.ReadLine());
            int count = 1;
            while (number > count)
            {
                if (count % 2 == 0)
                {
                    Console.Write($"{count},");
                }
                count = count + 1;
            }
            Console.WriteLine(" Все четные числа");
        }
    }
}