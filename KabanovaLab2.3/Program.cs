using System;

namespace KabanovaLab2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите 1,2 или 3");
                int n = int.Parse(Console.ReadLine());
                Console.Write("Введите x:");
                double x = double.Parse(Console.ReadLine());
                double a = 0, b = 0, z = 0, y;
                switch (n)
                {
                    case 1: a = -5; b = 2.5; z = Math.Log(Math.Abs(b * x * x * x)); break;
                    case 2: a = 3; b = 5; z = Math.Log(Math.Abs(b * x)); break;
                    case 3: a = -10; b = 3; z = Math.Log(Math.Abs(b * x * x)); break;
                }
                if (x < a) y = 2.8 * Math.Pow(Math.Sin(a * x - b * x * x * x * z), 2);
                else if (a <= x && x <= b * b) y = z * Math.Cos(Math.Pow(a * x + b, 2)) + Math.Log(z);
                else y = Math.Pow(Math.E, 2.5 * a * x) + z * a * b * x;
                Console.WriteLine($"y={y:F2}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
