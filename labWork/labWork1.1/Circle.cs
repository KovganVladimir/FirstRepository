using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labWork1
{
    public class Circle : IFigure
    {
        /// <summary>
        /// Радиус
        /// </summary>
        private double _radius;
        /// <summary>
        /// Координата фигуры по оси X
        /// </summary>
        private int _x;
        /// <summary>
        /// Координата фигуры по оси Y
        /// </summary>
        private int _y;
       


        public string Name
        {
            get
            {
                return "Круг";
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
        /// Радиус
        /// </summary>
        public double Radius
        {
            get 
            {
                return _radius;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Введите положительный радиус");
                }
                _radius = value;
            }
        }

        //int IFigure.X
        //{
        //    get
        //    {
        //        throw new NotImplementedException();
        //    }

        //    set
        //    {
        //        throw new NotImplementedException();
        //    }
        //}

        /// <summary>
        /// Метод,расчитывающий площадь фигур
        /// </summary>
        public double CalculationArea()
        {
            return (Math.PI * Math.Pow(_radius, 2) );
        }
    }
}
 




