// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


namespace CSharpHomeWork
{
    class Sem3Task21
    {
        static void Main(string[] args)

        {
            double Ax, Ay, Az, Bx, By, Bz, distance;

            Console.WriteLine("Расстояние между двумя точками в пространстве.");
            Console.Write("Введите координаты A(x): ");
            Ax = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите координаты A(y): ");
            Ay = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите координаты A(z): ");
            Az = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите координаты B(x): ");
            Bx = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите координаты B(y): ");
            By = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите координаты B(z): ");
            Bz = Convert.ToDouble(Console.ReadLine());

            distance = Math.Sqrt(Math.Pow(Bx - Ax, 2) + Math.Pow(By - Ay, 2) + Math.Pow(Bz - Az, 2));
            Console.WriteLine($"Расстояние между двумя точками в пространстве равно: {distance}");
        }
    }
}