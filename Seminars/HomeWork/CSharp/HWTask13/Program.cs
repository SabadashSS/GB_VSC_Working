// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int number = Convert.ToInt32(Console.ReadLine());
            var str = number.ToString();
            if (99 < number)
            {
                Console.WriteLine($"Третья цифра:{str[2]}");
            }
            else
            {
                Console.WriteLine($"Третьей цифры в числе {str} нет.");
            }

        }
    }
}