using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using NUnit.Framework;

namespace UnitTests.labWork1
{
    class TriangleTests
    {
        /// <summary>
        /// Тестирование свойства Side1
        /// </summary>
        [Test]
        [TestCase(0, TestName = "Тестирование Side1" + "при присвоении 0.")]
        [TestCase(int.MinValue, TestName = "Тестирование Side1 при присваивании int.MinValue.")]
        [TestCase(int.MaxValue - 1, TestName = "Тестирование Side1 при присваивании int.MaxValue-1.")]
        [TestCase(7, TestName = "Тестирование Side1" + "при присвоении 7.")]
        public void Side1Test(int side1)
        {
            var Triangle = new Triangle();
            Triangle.Side1 = side1;
        }
        /// <summary>
        /// Негативное тестирование свойства Side1
        /// </summary>
        [Test]
        [TestCase(-1, ExpectedResult = true, TestName = "Тестирование Width" + "при присвоении -1.")]
        public bool NegativeSide1Test(int side1)
        {
            try
            {
                var Triangle = new Triangle();
                Triangle.Side1 = side1;
            }
            catch (ArgumentException)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Тестирование свойства Side2
        /// </summary>
        [Test]
        [TestCase(0, TestName = "Тестирование Side1" + "при присвоении 0.")]
        [TestCase(int.MinValue + 1, TestName = "Тестирование Side1 при присваивании int.MinValue + 1.")]
        [TestCase(int.MaxValue - 1, TestName = "Тестирование Side1 при присваивании int.MaxValue - 1.")]
        [TestCase(10, TestName = "Тестирование Side1" + "при присвоении 10.")]
        public void Side2Test(int side2)
        {
            var Triangle = new Triangle();
            Triangle.Side2 = side2;
        }
        /// <summary>
        /// Негативное тестирование свойства Side2
        /// </summary>
        [Test]
        [TestCase(-8, ExpectedResult = true, TestName = "Тестирование Width" + "при присвоении -8.")]
        public bool NegativeSide2Test(int side2)
        {
            try
            {
                var Triangle = new Triangle();
                Triangle.Side2 = side2;
            }
            catch (ArgumentException)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Тестирование свойства Side3
        /// </summary>
        [Test]
        [TestCase(0, TestName = "Тестирование Side1" + "при присвоении 0.")]
        [TestCase(int.MinValue, TestName = "Тестирование Side1 при присваивании int.MinValue.")]
        [TestCase(int.MaxValue - 1, TestName = "Тестирование Side1 при присваивании int.MaxValue-1.")]
        [TestCase(11, TestName = "Тестирование Side1" + "при присвоении 11.")]
        public void Side3Test(int side3)
        {
            var Triangle = new Triangle();
            Triangle.Side3 = side3;
        }
        /// <summary>
        /// Негативное тестирование свойства Side3
        /// </summary>
        [Test]
        [TestCase(-35, ExpectedResult = true, TestName = "Тестирование Width" + "при присвоении -35.")]
        public bool NegativeSide3Test(int side3)
        {
            try
            {
                var Triangle = new Triangle();
                Triangle.Side3 = side3;
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
        [TestCase(2, 2, 2, 5, TestName = "Тестирование метода CalculationArea со значениями 2, 2 и 2,площадь должна получиться 5")]
        [TestCase(3, 8, 6, 10, TestName = "Тестирование метода CalculationArea со значениями 3, 8 и 6,площадь должна получиться 10")]
        [TestCase(1, 14, 2, 17, TestName = "Тестирование метода CalculationArea со значениями 1, 14 и 2,площадь должна получиться 17")]
        [TestCase(3, 4, 5, 6, TestName = "Тестирование метода CalculationArea со значениями 3, 4 и 5,площадь должна получиться 6")]
        public void CalculationArea_Test(int side1, int side2, int side3, double expected)
        {
            var Triangle = new Triangle();
            var actual = Triangle.CalculationArea();
            Assert.Equals(expected, actual);
        }
    }

}
