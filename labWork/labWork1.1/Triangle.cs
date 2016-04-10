using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Triangle : IFigure
    {
        /// <summary>
        /// Класс "Треугольник"
        /// </summary>
        /// <summary>
        /// Координата фигуры по оси X
        /// </summary>
        private int _x;//Координата фигуры по оси X
        /// <summary>
        /// Координата фигуры по оси Y
        /// </summary>
        private int _y;//Координата фигуры по оси Y
        /// <summary>
        /// Сторона 1
        /// </summary>
        private double _side1;
        /// <summary>
        /// Сторона 2
        /// </summary>
        private double _side2;
        /// <summary>
        /// Сторона 3
        /// </summary>
        private double _side3;
       

        public string Name
        {
            get
            {
                return "Треугольник";
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


        public double CalculationSemiperimetr()
        {
            return ((_side1 + _side2 + _side3) / 2);
        }
    
        /// <summary>
        /// Сторона 1
        /// </summary>
        public double Side1
        {
            get
            {
                return _side1;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Сторона 1 должна принимать положительное значение");
                }
                _side1 = value;
            }
        }
        /// <summary>
        /// Сторона 2
        /// </summary>
        public double Side2
        {
            get
            {
                return _side2;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Сторона 2 должна принимать положительное значение");
                }
                _side2 = value;
            }
        }
        /// <summary>
        /// Сторона 3
        /// </summary>
        public double Side3
        {
            get
            {
                return _side3;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Сторона 3 должна принимать положительное значение");
                }
                _side3 = value;
            }
        }
        
       
       
        /// <summary>
        /// Метод,расчитывающий площадь фигур
        /// </summary>
        public double CalculationArea()
        {
            var p = CalculationSemiperimetr();
            return (Math.Sqrt(p * (p - _side1) * (p - _side2) * (p - _side3)));
        }
    }
}

   


