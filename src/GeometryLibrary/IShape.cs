namespace GeometryLibrary
{
    /// <summary>
    /// Интерфейс для всех фигур, для которых можно вычислить площадь
    /// </summary>
    public interface IShape
    {
        /// <summary>
        /// Вычисляет площадь фигуры
        /// </summary>
        /// <returns>Площадь фигуры</returns>
        double CalculateArea();
    }
}