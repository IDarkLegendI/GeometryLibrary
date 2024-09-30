using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeometryLibrary;
using System;

namespace GeometryLibrary.Tests
{
    /// <summary>
    /// Набор тестов для проверки функциональности класса Triangle
    /// </summary>
    [TestClass]
    public class TriangleTests
    {
        /// <summary>
        /// Тестирование корректности вычисления площади треугольника
        /// </summary>
        [TestMethod]
        public void TriangleAreaTest()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.AreEqual(6, triangle.CalculateArea(), 1e-10);
        }

        /// <summary>
        /// Тестирование проверки на прямоугольный треугольник
        /// </summary>
        [TestMethod]
        public void RightAngledTriangleTest()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.IsTrue(triangle.IsRightAngled());
        }

        /// <summary>
        /// Тестирование некорректных значений сторон треугольника
        /// Ожидается выброс исключения ArgumentException
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InvalidTriangleTest()
        {
            var triangle = new Triangle(1, 2, 3); // Недопустимый треугольник
        }
    }
}