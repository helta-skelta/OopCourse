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

Console.Write("Пересечение диапазонов: ");

Range? rangesIntersection = range1.GetIntersection(range2);

if (rangesIntersection is null)
{
    Console.WriteLine("null");
}
else
{
    Console.WriteLine(rangesIntersection);
}

Console.WriteLine();
Console.Write("Обьединение диапазонов: ");

Range[] ranges = range1.GetUnion(range2);

Console.WriteLine(String.Join<Range>(" + ", (Range[])ranges));

Console.WriteLine();
Console.Write("Разность диапазонов: ");

ranges = range1.GetDifference(range2);

Console.WriteLine(String.Join<Range>(" + ", (Range[])ranges));