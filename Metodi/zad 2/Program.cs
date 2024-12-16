using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_2
{
    internal class Program
    {
        static void x(int x, int y, int z)
        {
            x += 5;
            y *= x;
            z = y * 10;
            Console.WriteLine("x=" + x);
            Console.WriteLine("y=" + y);
            Console.WriteLine("z=" + z);

        }
        static void Main(string[] args)
        {
            x(2, 3, 4);
        }
    }
}
