﻿using Shapes;

IShape[] shapes = { new Triangle(55.0, 9.0, 3.0, -2.0, 70.0, 3.0), new Rectangle(3.0, 6.0), new Square(8), new Circle(5), new Circle(8), new Rectangle(1.0, 8.0) };

static void MaxShapeArea(IShape[] shapes)
{
    Array.Sort(shapes, new ShapesComparer());

    Console.WriteLine($"Фигура с максимальной площадью = {shapes[^1]}");
    Console.WriteLine($"Площадь фигуры = {shapes[^1].GetArea():f2}");
    Console.WriteLine($"Периметр фигуры = {shapes[^1].GetPerimeter():f2}");
    Console.WriteLine($"Высота фигуры = {shapes[^1].GetHeight()}");
    Console.WriteLine($"Ширина фигуры = {shapes[^1].GetWidth()}");
}

static void SecondSizeShapePerimeter(IShape[] shapes)
{
    Array.Sort(shapes, new ShapesPerimetrComparer());

    Console.WriteLine($"Фигура со вторым по величине периметром = {shapes[^2]}");
    Console.WriteLine($"Площадь фигуры = {shapes[^2].GetArea():f2}");
    Console.WriteLine($"Периметр фигуры = {shapes[^2].GetPerimeter():f2}");
    Console.WriteLine($"Высота фигуры = {shapes[^2].GetHeight()}");
    Console.WriteLine($"Ширина фигуры = {shapes[^2].GetWidth()}");
}

MaxShapeArea(shapes);
SecondSizeShapePerimeter(shapes);