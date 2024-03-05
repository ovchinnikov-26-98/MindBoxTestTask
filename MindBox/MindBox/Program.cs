using SquareFigureLibrary;

var circle = new Circle(3.5);
var circleArea = ShapeCalculator.CalculateArea(circle);
Console.WriteLine($"Площадь круга: {circleArea}");

var triangle = new Triangle(6.8, 3.2, 9);
var triangleArea = ShapeCalculator.CalculateArea(triangle);
Console.WriteLine($"Площадь треугольника: {triangleArea}");