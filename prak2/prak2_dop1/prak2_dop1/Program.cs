using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prak2_dop1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стороны прямоугольника");
            Console.Write("Введите сторону A: ");
            int A = int.Parse(Console.ReadLine());
            Console.Write("Введите сторонy B: ");
            int B = int.Parse(Console.ReadLine());
            Console.Write("Введите сторонy квадрата: ");
            int C = int.Parse(Console.ReadLine());
            int SSquare = C * C, count = 0, S = A * B;

            while (S >= SSquare)
            {
                S -= SSquare;
                count++;
            }

            Console.WriteLine($"Mаксимальное число квадратов в прямоугольнике = {count}");

        }
    }
}
