using NUnit.Framework;
using SquareFigureLibrary;
using System;

namespace TestSquareFigureLibrary
{
    [TestFixture]
    public class ShapeCalculatorTests
    {
        //Созданим новую фигуру для теста
        private class Rectangle : IShape
        {
            private double width;
            private double height;

            public Rectangle(double width, double height)
            {
                this.width = width;
                this.height = height;
            }

            public double CalculateArea()
            {
                return width * height;
            }
        }


        [Test]
        public void CalculateRectangleArea_ValidSides_ReturnsCorrectArea()
        {
            var rectangle = new Rectangle(5,4);
         
            var actualArea = ShapeCalculator.CalculateArea(rectangle);
                        
            Assert.AreEqual(20, actualArea);
        }

        [Test]
        public void CalculateRectangleArea_InvalidSides_ReturnsCorrectArea()
        {
            var rectangle = new Rectangle(5, 0);

            Assert.Throws<ArgumentException>(() => ShapeCalculator.CalculateArea(rectangle));
        }
    }
}