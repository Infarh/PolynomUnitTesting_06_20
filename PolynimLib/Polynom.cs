using System;
using System.Collections.Generic;
using System.Text;

namespace PolynimLib
{
    /// <summary>Полином</summary>
    /// <remarks>
    /// a[0]+a[1]*x+a[2]*x^2+...+a[N-1]*x^(N-1)+a[N-1]*x^(N-1)
    /// </remarks>
    public class Polynom
    {
        private readonly double[] _a;

        public Polynom(double[] a)
        {
            _a = a;
        }

        /// <summary>Вычисление значения полинома по схеме Горнера</summary>
        /// <param name="x">Значение аргумента</param>
        /// <returns>Значение полинома в точке x</returns>
        public double Value(double x)
        {
            // y = a[n]x^n + a[n-1]x^(n-1)+...+a[0]
            // y = ax^3 + bx^2 + cx + d
            // y = ((a * x + b) * x + c) * x + d

            var len = _a.Length;
            if (len == 0) 
                return double.NaN;
            var y = _a[_a.Length - 1];
            for (var n = len - 2; n >= 0; n--)
                y = y * x + _a[n];
            return y;
        }

        /// <summary>Вычисление значения полинома в лоб</summary>
        /// <param name="x">Значение аргумента</param>
        /// <returns>Значение полинома в точке x</returns>
        public double Value2(double x)
        {
            var y = 0d;
            for (var n = 0; n < _a.Length; n++)
                y += _a[n] * Math.Pow(x, n);

            return y;
        }
    }
}
