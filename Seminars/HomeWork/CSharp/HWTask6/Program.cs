// //Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Является число четным?");
            Console.WriteLine("Введите число:");
            int Number = Convert.ToInt32(Console.ReadLine());
            if (Number % 2 == 0)
            {
                Console.WriteLine($"Число {Number} четное");
            }
            else
            {
                Console.WriteLine($"Число {Number} Не четное");
            }

        }
    }
}