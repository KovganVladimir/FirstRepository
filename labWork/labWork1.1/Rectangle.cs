using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labWork1
{
    /// <summary>
    /// Класс "Прямоугольник"
    /// </summary>
    public class Rectangle : IFigure
    {
        /// <summary>
        /// Координата фигуры по оси X
        /// </summary>
        private int _x;
        /// <summary>
        /// Координата фигуры по оси Y
        /// </summary>
        private int _y;
        /// <summary>
        /// Длина
        /// </summary>
        private double _length;
        /// <summary>
        /// Ширина
        /// </summary>
        private double _width;
        


        public string Name
        {
            get
            {
                return "Прямоугольник";
            }
        }


        public int X
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
            }
        }

        public int Y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }
        }
        /// <summary>
        /// Длина
        /// </summary>
        public double Length
        {
            get
            {
                return _length;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Длина должна принимать положительное значение");
                }
                _length = value;
            }
        }

        /// <summary>
        /// Ширина
        /// </summary>
        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Ширина должна принимать положительное значение");
                }
                _width = value;
            }
        }
        /// <summary>
        /// Метод,расчитывающий площадь фигур
        /// </summary>
        public double CalculationArea()
        {
            return (_length * _width);
        }
    }
}


     


