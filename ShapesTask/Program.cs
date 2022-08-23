using ShapesTask.Shapes;
using ShapesTask.Comparers;

static IShape GetShapeWithMaxArea(IShape[] shapes)
{
    if (shapes is null)
    {
        throw new ArgumentNullException(nameof(shapes), "Массив фигур равен null.");
    }

    if (shapes.Length == 0)
    {
        throw new ArgumentException("Массив фигур пустой.", nameof(shapes));
    }

    Array.Sort(shapes, new AreaComparer());

    return shapes[^1];
}

static IShape GetShapeWithSecondLargestPerimeter(IShape[] shapes)
{
    if (shapes is null)
    {
        throw new ArgumentNullException(nameof(shapes), "Массив фигур равен null.");
    }

    if (shapes.Length < 2)
    {
        throw new ArgumentException("Количество фигур в массиве меньше двух", nameof(shapes));
    }

    Array.Sort(shapes, new PerimeterComparer());

    return shapes[^2];
}

IShape[] shapes =
{
    new Triangle(50.0, 9.0, 3.0, 2.0, 90.0, 3.0),
    new Rectangle(3.0, 6.0),
    new Square(8),
    new Circle(5),
    new Circle(6),
    new Rectangle(1.0, 8.0)
};

Console.WriteLine("Фигура с максимальной площадью = " + GetShapeWithMaxArea(shapes));
Console.WriteLine("Фигура со вторым по величине периметром = " + GetShapeWithSecondLargestPerimeter(shapes));