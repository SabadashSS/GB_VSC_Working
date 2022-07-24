// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

namespace CSharpHomeWork
{
    class Sem3Task19
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 5ти значное число");
            int number = Convert.ToInt32(Console.ReadLine());
            var str = number.ToString();
            if (str.Length == 5)
            {
                if (str[0] == str[4] && str[1] == str[3])
                {
                    Console.WriteLine($"Введенное число {number} является палиндромом");
                }
                else
                {
                    Console.WriteLine($"Введенное число {number} не является палиндромом");
                }
            }
            else
            {
                Console.WriteLine("Введено не верное значение");
            }
        }
    }
}