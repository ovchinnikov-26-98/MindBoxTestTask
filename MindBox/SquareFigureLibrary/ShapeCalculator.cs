using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareFigureLibrary
{
    public class ShapeCalculator
    {
        public static double CalculateArea<TShape>(TShape shape)
            where TShape : IShape
        {
            var area = shape.CalculateArea();
            if (area <= 0) throw new ArgumentException("Площадь не может быть отрицательной или равно 0");
            return area;
        }
    }
}
