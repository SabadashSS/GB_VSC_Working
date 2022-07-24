// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


namespace Sem6Task41
{
    class Program
    {
        static void Main(string[] asgs)
        {
            Console.Write("Введите положительные или отрицательные числа, через пробел: ");
            int[] numberEnd = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < numberEnd.Length; i++)
            {
                Console.Write(numberEnd[i] + " | ");
            }
            Console.WriteLine();
            Console.WriteLine($"Вы ввели {GetPlus(numberEnd)} положительных чисел");
        }
        public static int[] GetIntArray(string[] array)
        {
            int[] arrayEnd = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                arrayEnd[i] = int.Parse((array[i]).ToString());
            }
            return arrayEnd;
        }
        public static int GetPlus(int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}