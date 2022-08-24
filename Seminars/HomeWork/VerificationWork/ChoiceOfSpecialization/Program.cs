// Итоги блока. Выбор специализации. Контрольная работа.



﻿namespace finalHW
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите элементы через пробел");
            string? str = Console.ReadLine();
            string [] array = str.Split(" ");
            Console.WriteLine("Сформирован массив из строк, длинна которых не более 3ех символов");
            PrintArray(GetArray(array));
        }

        public static string [] GetArray (string [] array)
        {
            string [] finalArray = new string [array.Length];
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                string str = array[i];
                int length = str.Length;
                if(length <= 3)
                {
                    finalArray[index] = array[i];
                    index++;
                }
            }
            return finalArray;
        }
        public static void PrintArray (string [] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}