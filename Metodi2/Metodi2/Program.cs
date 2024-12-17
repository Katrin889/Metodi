using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodi2
{
    internal class Program
    {
        static void number()
        {
            int a = int.Parse(Console.ReadLine());
            int b = a % 10;
            if (b == 0) { Console.WriteLine("Zero"); }
            else if (b == 1) { Console.WriteLine("One"); }
            if (b == 2) { Console.WriteLine("Two"); }
            if (b == 3) { Console.WriteLine("Thee"); }
            else if (b == 4) { Console.WriteLine("Four"); }
            if (b == 5) { Console.WriteLine("Five"); }
            else if (b == 6) { Console.WriteLine("Six"); }
            if (b == 7) { Console.WriteLine("Seven"); }
            else if (b == 8) { Console.WriteLine("Eight"); }
            if (b == 9) { Console.WriteLine("Nine"); }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            number();
        }
    }
}
