namespace GeometryLibrary
{
    /// <summary>
    /// Вспомогательный класс для вычисления площади фигур
    /// </summary>
    public static class ShapeAreaCalculator
    {
        /// <summary>
        /// Возвращает площадь заданной фигуры
        /// </summary>
        /// <param name="shape">Фигура, для которой вычисляется площадь</param>
        /// <returns>Площадь фигуры</returns>
        public static double GetArea(IShape shape)
        {
            return shape.CalculateArea();
        }
    }
}