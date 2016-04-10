using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Интерфейс,геометрической фигуры
    /// </summary>
    public interface IFigure
    {
        /// <summary>
        /// Координата фигуры по оси X
        /// </summary>
        int X { get; set; }
        /// <summary>
        /// Координата фигуры по оси Y
        /// </summary>
        int Y { get; set; }
        string Name { get; }
        /// <summary>
        /// Метод,расчитывающий площадь фигур
        /// </summary>
        double CalculationArea();
    }
}
