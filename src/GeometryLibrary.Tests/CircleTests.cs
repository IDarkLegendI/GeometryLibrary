using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeometryLibrary;
using System;

namespace GeometryLibrary.Tests
{
    /// <summary>
    /// Набор тестов для проверки функциональности класса Circle
    /// </summary>
    [TestClass]
    public class CircleTests
    {
        /// <summary>
        /// Тестирование корректности вычисления площади круга
        /// </summary>
        [TestMethod]
        public void CircleAreaTest()
        {
            var circle = new Circle(5);
            Assert.AreEqual(Math.PI * 25, circle.CalculateArea(), 1e-10);
        }
    }
}