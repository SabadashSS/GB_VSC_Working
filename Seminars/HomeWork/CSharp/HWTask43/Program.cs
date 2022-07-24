// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, 
// y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

namespace Sem6Task43
{
    class Program
    {
        static void Main(string[] asgs)
        {
            Console.WriteLine("Поиск точки пересечения двух прямых");
            Console.Write("Введите точку k1: ");
            double k1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите точку b1: ");
            double b1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите точку k2: ");
            double k2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите точку b2: ");
            double b2 = Convert.ToDouble(Console.ReadLine());
            double[] arrayXY = GetPoint(k1, b1, k2, b2);
            Console.WriteLine($"Координаты точки пересечения x = {arrayXY[0]}, y = {arrayXY[1]}");
        }

        public static double[] GetPoint(double k1, double b1, double k2, double b2)
        {
            double[] arrayPoint = new double[2];
            double x;
            double y;
            x = (b2 - b1) / (k1 - k2);
            y = k1 * x + b1;
            arrayPoint[0] = x;
            arrayPoint[1] = y;
            return arrayPoint;
        }
    }
}