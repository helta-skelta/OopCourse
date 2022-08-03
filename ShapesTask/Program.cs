using ShapesTask;

IShape[] shapes =
{
    new Triangle(50.0, 9.0, 3.0, 2.0, 90.0, 3.0),
    new Rectangle(3.0, 6.0),
    new Square(8),
    new Circle(5),
    new Circle(6),
    new Rectangle(1.0, 8.0)
};

static IShape MaxShapeArea(IShape[] shapes)
{
    if (shapes is null || shapes.Length == 0)
    {
        throw new ArgumentException("Массив фигур пустой или равен null");
    }

    Array.Sort(shapes, new AreaComparer());

    return shapes[^1];
}

static IShape SecondSizeShapePerimeter(IShape[] shapes)
{
    if (shapes is null || shapes.Length == 0)
    {
        throw new ArgumentException("Массив фигур пустой или равен null");
    }

    Array.Sort(shapes, new PerimeterComparer());

    return shapes[^2];
}

Console.WriteLine(MaxShapeArea(shapes));
Console.WriteLine(SecondSizeShapePerimeter(shapes));