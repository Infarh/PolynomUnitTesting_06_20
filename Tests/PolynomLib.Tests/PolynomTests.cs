using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PolynimLib;
// ReSharper disable EmptyArray

namespace PolynomLib.Tests
{
    [TestClass]
    public class PolynomTests
    {
        [TestMethod]
        public void Value_Returns_correct_result()
        {
            // A-A-A
            // Arrange - Act - Assert

            #region Arrange
            
            double[] a = { 7, 5, 3 };
            var x = 5d;
            var expected_y = 107d;

            var polynom = new Polynom(a);

            #endregion

            #region Act

            var actual_y = polynom.Value(x); 

            #endregion

            Assert.IsFalse(double.IsNaN(actual_y));
            Assert.AreEqual(expected_y, actual_y);
        }

        [TestMethod]
        public void Value_Returns_NaN_for_ZeroLength_polynom()
        {
            var p = new Polynom(new double[0]);
            var x = 0;
            var expected_y = double.NaN;

            var actual_y = p.Value(x);

            Assert.AreEqual(expected_y, actual_y);
        }

        [TestMethod]
        public void Value2_Returns_correct_result()
        {
            // A-A-A
            // Arrange - Act - Assert

            #region Arrange

            double[] a = { 7, 5, 3 };
            var x = 5d;
            var expected_y = 107d;

            var polynom = new Polynom(a);

            #endregion

            #region Act

            var actual_y = polynom.Value2(x);

            #endregion

            Assert.IsFalse(double.IsNaN(actual_y));
            Assert.AreEqual(expected_y, actual_y);
        }

        [TestMethod]
        public void Differential_Returns_correct_Polynom()
        {
            //y = 7 + 5x + 3x^2
            var p = new Polynom(7, 5, 3);
            const double expected_a0 = 5;
            const double expected_a1 = 3 * 2;

            // diff_y = 5 + 6x
            var diff_p = p.GetDifferential();

            Assert.IsNotNull(diff_p);
            Assert.AreEqual(expected_a0, diff_p[0]);
            Assert.AreEqual(expected_a1, diff_p[1]);
        }
    }
}
