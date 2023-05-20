using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("l="); 
            int l=Convert.ToInt32(Console.ReadLine());
            l = l / 100;
            Console.WriteLine($"{l}m");
        }
    }
}
