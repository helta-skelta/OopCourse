Console.WriteLine("Введите два числа диапазона.");

Console.Write("Начало диапазона: ");
double from = Convert.ToDouble(Console.ReadLine());

Console.Write("Конец диапазона: ");
double to = Convert.ToDouble(Console.ReadLine());

RangeTask.Range range = new(from, to);

Console.WriteLine("Длина диапазона: " + range.GetLength());

Console.Write("Введите число для проверки принадлежности данному диапазону: ");
double number = Convert.ToDouble(Console.ReadLine());

if (range.IsInside(number))
{
    Console.WriteLine($"Число {number} лежит в диапазоне от {from} до {to}.");
}
else
{
    Console.WriteLine($"Число {number} не лежит в диапазоне от {from} до {to}.");
}