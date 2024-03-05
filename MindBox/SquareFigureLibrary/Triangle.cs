using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareFigureLibrary
{
    public class Triangle : IShape
    {
        private double side1;
        private double side2;
        private double side3;

        public Triangle(double side1, double side2, double side3)
        {
            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
            {
                throw new ArgumentException("Стороны должны быть положительными числами");
            }

            if (!IsValidTriangle(side1, side2, side3))
            {
                throw new ArgumentException("Треугольник с такими сторонами не существует");
            }

            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        public double CalculateArea()
        {
            var semiPerimeter = (side1 + side2 + side3) / 2;
            var area = Math.Sqrt(semiPerimeter * (semiPerimeter - side1) * (semiPerimeter - side2) * (semiPerimeter - side3));

            return area;
        }

        public bool IsRightTriangle()
        {
            var a2 = Math.Pow(side1, 2);
            var b2 = Math.Pow(side2, 2);
            var c2 = Math.Pow(side3, 2);

            return (a2 + b2 == c2) || (a2 + c2 == b2) || (b2 + c2 == a2);
        }

        private bool IsValidTriangle(double sideA, double sideB, double sideC)
        {
            return (sideA + sideB > sideC) && (sideB + sideC > sideA) && (sideC + sideA > sideB);
        }
    }
}
