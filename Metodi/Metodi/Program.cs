using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodi
{
    internal class Program
    {
        static void Ime()
        {
            Console.Write("Name: ");
            var a = Console.ReadLine();
            Console.WriteLine("Hallo, " + a);
        }
        static void Main(string[] args)
        {
            Ime();
        }
    }
}
