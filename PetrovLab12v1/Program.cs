using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrovLab12v1
{
    class Program
    {
        //Разработать статический класс для работы с окружностью. Класс должен содержать 3 метода:
        //метод, определяющий длину окружности по заданному радиусу;
        //метод, определяющий площадь круга по заданному радиусу;
        //метод, проверяющий принадлежность точки с координатами(x, y) кругу с радиусом r и координатами центра x0, y0.
        static void Main(string[] args)
        {
            // Проверку корректности ввода данных опустил для простоты кода.
            Console.WriteLine("Ведите радиус окружности");
            int rad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Длина окружности равна {0:f4}", ModRound.LengthR(rad));
            Console.WriteLine("Площадь окружности равна {0:f4}", ModRound.SquareR(rad));
            Console.WriteLine("Ведите координаты точки");
            int x0 = Convert.ToInt32(Console.ReadLine());
            int y0 = Convert.ToInt32(Console.ReadLine());
            if (ModRound.AccessoriesR(rad, x0, y0))
            {
                Console.WriteLine("Точка с заданными координатами принадлежить области круга");
            }
            else
            {
                Console.WriteLine("Точка с заданными координатами не принадлежить области круга");
            }
            Console.ReadKey();
        }
    }
    public static class ModRound
    {
        internal static double LengthR(int r) // Длина окружности
        {
            return (double)2 * Math.PI * r;
        }

        internal static Boolean AccessoriesR(int r, int x, int y) // Принадлежность точки к кругу
        {
            if (Math.Sqrt((double)Math.Pow(x, 2) + Math.Pow(y, 2))<=r)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        internal static double SquareR(int value) // Площадь окружности
        {
            return (double)Math.Pow(value, 2) * Math.PI;
        }
    }
}
