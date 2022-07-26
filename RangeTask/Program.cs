using Range = RangeTask.Range;

Console.WriteLine("Введите начало и конец двух диапазонов чисел.");

Console.Write("Начало первого диапазона: ");
double from1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Конец первого диапазона: ");
double to1 = Convert.ToDouble(Console.ReadLine());

Range range1 = new(from1, to1);

Console.Write("Начало вторго диапазона: ");
double from2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Конец второго диапазона: ");
double to2 = Convert.ToDouble(Console.ReadLine());

Range range2 = new(from2, to2);

Range? rangesIntersection = range1.GetIntersection(range2);

if (rangesIntersection is null)
{
    Console.WriteLine("null");
}
else
{
    Console.WriteLine("Пересечение диапазонов: " + rangesIntersection);
}

Console.WriteLine();

Range[] ranges = range1.GetUnion(range2);

if (ranges.Length == 0)
{
    Console.WriteLine(0);
}
else
{
    Console.Write("Обьединение диапазонов: [");
    Console.Write(String.Join<Range>(", ", (Range[])ranges));
    Console.WriteLine("]");
}

Console.WriteLine();

ranges = range1.GetDifference(range2);

if (ranges.Length == 0)
{
    Console.WriteLine(0);
}
else
{
    Console.Write("Разность диапазонов: [");
    Console.Write(String.Join<Range>(", ", (Range[])ranges));
    Console.WriteLine("]");
}