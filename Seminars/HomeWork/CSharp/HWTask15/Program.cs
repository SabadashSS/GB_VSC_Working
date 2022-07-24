// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


namespace HelloWorld 
{
    class Program 
    { 
        static void Main(string[] args) 
        { 
            Console.WriteLine("Введите цифру дня недели:");
            int number = Convert.ToInt32(Console.ReadLine());
            var str = number.ToString();
            if (number < 6 && number > 0)
            {
            Console.WriteLine("Рабочий день");
            }
            else
            {
                if (number >= 6 && number <= 7)
                {
                Console.WriteLine("Выходной день");
                }
                else
                {
                Console.WriteLine("Не соответсвует дню недели");
                }
            }

        } 
    } 
}