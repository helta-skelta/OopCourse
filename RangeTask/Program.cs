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

Range? intervalsIntersection = new();
intervalsIntersection = intervalsIntersection.GetIntervalsIntersection(range1, range2);

Console.WriteLine();
Console.WriteLine("Пересечение интервалов.");
Console.WriteLine();

if (intervalsIntersection is null)
{
    Console.WriteLine("null");
}
else
{
    Console.WriteLine($"Длинна интервала-пересечения = {intervalsIntersection.GetLength()}.");
    Console.WriteLine($"Начало интервала-пересечения = {intervalsIntersection.From}. Конец интервала-пересечения = {intervalsIntersection.To}.");
}

Range[] intervalsJoining = range1.GetIntervalsJoining(range1, range2);

Console.WriteLine();
Console.WriteLine("Обьединение интервалов.");
Console.WriteLine();

if (intervalsJoining is null)
{
    Console.WriteLine("null");
}
else
{
    if (intervalsJoining.Length == 1)
    {
        Console.WriteLine($"Длинна обьединенных интервалов = {intervalsJoining[0].GetLength()}");
        Console.WriteLine($"Начало обьединенного интервала = {intervalsJoining[0].From}. Конец обьединенного интервала = {intervalsJoining[0].To}.");
    }
    else
    {
        Console.WriteLine($"Длинна обьединенных интервалов = {intervalsJoining[0].GetLength() + intervalsJoining[1].GetLength()}.");
        Console.WriteLine($"Начало первого интервала = {intervalsJoining[0].From}. Конец первого интервала = {intervalsJoining[0].To}.");
        Console.WriteLine($"Начало второго интервала = {intervalsJoining[1].From}. Конец второго интервала = {intervalsJoining[1].To}.");
    }
}

Range[]? intervalsDifference = range1.GetIntervalsDifference(range1, range2);

Console.WriteLine();
Console.WriteLine("Разность интервалов.");
Console.WriteLine();

if (intervalsDifference is null)
{
    Console.WriteLine("null");
}
else
{
    if (intervalsDifference.Length == 1)
    {
        Console.WriteLine($"Длинна интервала = {intervalsDifference[0].GetLength()}.");
        Console.WriteLine($"Начало интервала = {intervalsDifference[0].From}. Конец интервала = {intervalsDifference[0].To}.");
    }
    else
    {
        Console.WriteLine($"Длинна интервала = {intervalsDifference[0].GetLength() + intervalsDifference[1].GetLength()}");
        Console.WriteLine($"Начало первого интервала = {intervalsDifference[0].From}. Конец первого интервала = {intervalsDifference[0].To}.");
        Console.WriteLine($"Начало второго интервала = {intervalsDifference[1].From}. Конец второго интервала = {intervalsDifference[1].To}.");
    }
}