using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prak2_dop2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("write year:");
            int year = Convert.ToInt32(Console.ReadLine());
            year = (year / 100) + 1;
            Console.WriteLine($"{year} столетие на дворе");
        }
    }
}
