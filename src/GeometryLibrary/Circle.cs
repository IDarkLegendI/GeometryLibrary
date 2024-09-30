using System;

namespace GeometryLibrary
{
    /// <summary> 
    /// Класс, представляющий круг, с возможностью вычисления его площади
    /// </summary>
    public class Circle : IShape
    {
        /// <summary>
        /// Радиус круга
        /// </summary>
        public double Radius { get; }

        /// <summary>
        /// Инициализирует новый экземпляр класса Circle с заданным радиусом
        /// </summary>
        /// <param name="radius">Радиус круга.</param>
        public Circle(double radius)
        {
            Radius = radius;
        }

        /// <summary>
        /// Вычисляет площадь круга
        /// </summary>
        /// <returns>Площадь круга.</returns>
        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}