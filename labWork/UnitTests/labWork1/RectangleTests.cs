using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using NUnit.Framework;

namespace UnitTests.labWork1
{
    /// <summary>
    /// Набор тестов для класса Rectangle
    /// </summary>
    class RectangleTests
    {
        /// <summary>
        /// Тестирование свойства Length
        /// </summary>
        [Test]
        [TestCase(0, TestName = "Тестирование Length при присвоении 0.")]
        [TestCase(int.MinValue, TestName = "Тестирование Length при присваивании int.MinValue.")]
        [TestCase(int.MaxValue, TestName = "Тестирование Length при присваивании int.MaxValue.")]
        [TestCase(1, TestName = "Тестирование Length при присвоении 1.")]
        public void LengthTest(int length)
        {
            var Rectangle = new Rectangle();
            Rectangle.Length = length;
        }
        /// <summary>
        /// Негативное тестирование свойства Length
        /// </summary>
        [Test]
        [TestCase(-3, ExpectedResult = true, TestName = "Тестирование Width" + "при присвоении -3.")]
        public bool NegativeLengthTest(int length)
        {
            try
            {
                var Rectangle = new Rectangle();
                Rectangle.Length = length;
            }
            catch (ArgumentException)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Тестирование свойства Width
        /// </summary>
        [Test]
        [TestCase(0, TestName = "Тестирование Width при присвоении 0.")]
        [TestCase(int.MinValue, TestName = "Тестирование Width при присваивании int.MinValue.")]
        [TestCase(int.MaxValue, TestName = "Тестирование Width при присваивании int.MaxValue.")]
        [TestCase(2, TestName = "Тестирование Width при присвоении 2.")]
        public void WidthTest(int width)
        {
            var Rectangle = new Rectangle();
            Rectangle.Width = width;
        }
        /// <summary>
        /// Негативное тестирование свойства Width
        /// </summary>
        [Test]
        [TestCase(-1, ExpectedResult = true, TestName = "Тестирование Width при присвоении -1.")]
        public bool NegativeWidthTest(int width)
        {
            try
            {
                var Rectangle = new Rectangle();
                Rectangle.Width = width;
            }
            catch (ArgumentException)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Тестирование метода CalculationArea()
        /// </summary>
        [TestCase(5, 10, 50, TestName = "Тестирование метода CalculationArea со значениями 5 и 10,площадь должна получиться 50")]
        [TestCase(4, 15, 60, TestName = "Тестирование метода CalculationArea со значениями 4 и 15,площадь должна получиться 60")]
        [TestCase(8, 11, 88, TestName = "Тестирование метода CalculationArea со значениями 8 и 11,площадь должна получиться 88")]
        [TestCase(10, 15, 150, TestName = "Тестирование метода CalculationArea со значениями 10 и 15,площадь должна получиться 150")]
        public void CalculationArea_Test(int length, int width, double expected)
        {
            var Rectangle = new Rectangle();
            var actual = Rectangle.CalculationArea();
            Assert.Equals(expected, actual);
        }

    }

}