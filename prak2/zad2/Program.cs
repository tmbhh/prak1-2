using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vvedite 3 znachnoe chislo");
            string str = Console.ReadLine();
            char[] a = str.ToCharArray();
            Console.WriteLine($"{a[2]}{a[0]}{a[1]}");
        }
    }
}
