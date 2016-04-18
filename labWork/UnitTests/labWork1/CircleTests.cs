using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using NUnit.Framework;

namespace UnitTests
{
    /// <summary>
    /// Набор тестов для класса Circle
    /// </summary>
    [TestFixture]
    public class CircleTests
    {
        /// <summary>
        /// Тестирование свойства Radius
        /// </summary>
        [Test]
        [TestCase(0, TestName = "Тестирование Radius при присвоении 0.")]
        [TestCase(int.MinValue, TestName = "Тестирование Radius при присваивании int.MinValue.")]
        [TestCase(int.MaxValue, TestName = "Тестирование Radius при присваивании int.MaxValue.")]
        [TestCase(5, TestName = "Тестирование Radius при присвоении 5.")]
        public void RadiusTest(int radius)
        {
            var Circle = new Circle();
            Circle.Radius = radius;
        }

        /// <summary>
        /// Негативное тестирование свойства Radius
        /// </summary>
        [Test]
        [TestCase(-5, ExpectedResult = true, TestName = "Тестирование Radius при присвоении -5.")]
        public bool NegativeRadiusTest(int radius)
        {
            try
            {
                var Circle = new Circle();
                Circle.Radius = radius;
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
        [TestCase(1, Math.PI, TestName = "Тестирование метода CalculationArea со значением радиуса 1, площадь должна получиться равная числу пи")]
        [TestCase(4, 6, TestName = "Тестирование метода CalculationArea со значением радиуса 4, площадь должна получиться  6")]
        [TestCase(3, 8, TestName = "Тестирование метода CalculationArea со значением радиуса 3 ,площадь должна получиться 8")]
        [TestCase(2, 15, TestName = "Тестирование метода CalculationArea со значением радиуса 2 ,площадь должна получиться 15")]
        public void CalculationArea_Test(int radius, double expected)
        {
            var Circle = new Circle();
            var actual = Circle.CalculationArea();
            Assert.Equals(expected, actual);
        }
    }
}

