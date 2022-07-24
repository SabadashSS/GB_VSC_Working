// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 3ех значное число:");
            int number = Convert.ToInt32(Console.ReadLine());
            var str = number.ToString();
            if (99 < number && number < 1000)
            {
                Console.WriteLine($"Вторая цифра:{str[1]}");
            }
            else
            {
                Console.WriteLine($"Не соответсвует условиям:{str}");
            }

        }
    }
}