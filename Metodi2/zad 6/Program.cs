using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_6
{
    internal class Program
    {
        static void nu()
        {
            int a = int.Parse(Console.ReadLine());
            int b = 1;
            int c = 1;
            while (a >= b)
            {
                c = c * b;
                b++;
            }
            Console.WriteLine(c);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            nu();
        }
    }
}
