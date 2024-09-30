using System;

namespace GeometryLibrary
{
    /// <summary>
    /// Класс, представляющий треугольник, с возможностью вычисления его площади и проверки, является ли он прямоугольным
    /// </summary>
    public class Triangle : IShape
    {
        /// <summary>
        /// Длина первой стороны треугольника
        /// </summary>
        public double SideA { get; }

        /// <summary>
        /// Длина второй стороны треугольника
        /// </summary>
        public double SideB { get; }

        /// <summary>
        /// Длина третьей стороны треугольника
        /// </summary>
        public double SideC { get; }

        /// <summary>
        /// Инициализирует новый экземпляр класса Triangle с заданными длинами сторон
        /// </summary>
        /// <param name="sideA">Длина первой стороны</param>
        /// <param name="sideB">Длина второй стороны</param>
        /// <param name="sideC">Длина третьей стороны</param>
        /// <exception cref="ArgumentException">Выбрасывается, если стороны не образуют треугольник</exception>
        public Triangle(double sideA, double sideB, double sideC)
        {
            // Проверка на допустимые значения сторон
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
                throw new ArgumentException("Стороны должны быть больше нуля.");
            if (!IsValidTriangle(sideA, sideB, sideC))
                throw new ArgumentException("Некорректные длины сторон для треугольника.");

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        /// <summary>
        /// Вычисляет площадь треугольника с использованием формулы Герона
        /// </summary>
        /// <returns>Площадь треугольника</returns>
        public double CalculateArea()
        {
            double s = (SideA + SideB + SideC) / 2; // Полупериметр
            return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
        }

        /// <summary>
        /// Проверяет, является ли треугольник прямоугольным
        /// </summary>
        /// <returns>True, если треугольник прямоугольный, иначе False</returns>
        public bool IsRightAngled()
        {
            double[] sides = { SideA, SideB, SideC };
            Array.Sort(sides); // Сортируем стороны для упрощения проверки
            // Проверяем теорему Пифагора
            return Math.Abs(sides[2] * sides[2] - (sides[0] * sides[0] + sides[1] * sides[1])) < 1e-10;
        }

        /// <summary>
        /// Проверяет, можно ли по данным длинам сторон построить треугольник
        /// </summary>
        /// <param name="sideA">Длина первой стороны</param>
        /// <param name="sideB">Длина второй стороны</param>
        /// <param name="sideC">Длина третьей стороны</param>
        /// <returns>True, если треугольник допустим, иначе False</returns>
        private static bool IsValidTriangle(double sideA, double sideB, double sideC)
        {
            // Проверка неравенства треугольника
            return sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA;
        }
    }
}
