using System;
using PolynimLib;

namespace PolynomUnitTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] a = { 7, 5, 3 };
            var p = new Polynom(a);
            // y = 3x^2 + 5x + 7

            var y0 = p.Value(0); // 7
            var y1 = p.Value(1); // 15
            var y5 = p.Value(5); // 107

            Console.WriteLine("Конец!");
            Console.ReadLine();
        }
    }
}
