using VectorTask;

double[] components1 = { 3, 5, 6, 7 };
double[] components2 = { 1, 2, 3, 8, 9, 10, -1 };

Vector a = new(components1);
Vector b = new(10, components2);
Vector c = new(a);
Vector d = new(7);

d.Joining(b);
Console.WriteLine("Прибавили к вектору \"d\" вектор \"b\" = " + d);

Console.WriteLine("Размер вектора \"d\" = " + d.GetSize());
Console.WriteLine("Длинна вектора \"d\" = " + d.GetLength());
Console.WriteLine("Компонента вектора \"d\" под индексом \"3\" = " + d[3]);
Console.WriteLine();

d[3] = 6;//Установили компоненту вектора "d" под индексом 3

d.Subtraction(a);
Console.WriteLine("Вычли из вектора \"d\" вектор \"a\" = " + d);

c.ScalarMultiply(2.0);
Console.WriteLine("Умножили вектор \"c\" на 2 = " + c);

c.Reverse();
Console.WriteLine("Разворот вектора \"c\"  = " + c);

if (c == b)
{
    Console.WriteLine("Вектор \"с\" равен вектору \"b\"");
}
else
{
    Console.WriteLine("Вектор \"с\" не равен вектору \"b\"");
}

Console.WriteLine("Хэш-код вектора \"c\" = " + c.GetHashCode());
Console.WriteLine("Хэш-код вектора \"b\" = " + b.GetHashCode());

Console.WriteLine(a);
Console.WriteLine(b);

Console.WriteLine("Разность векторов \"a\" и \"b\" = " + Vector.Subtract(a, b));

Console.WriteLine(a);
Console.WriteLine(b);

Console.WriteLine("Сумма векторов \"a\" и \"b\" = " + Vector.Join(a, b));
Console.WriteLine("Разность векторов \"a\" и \"b\" = " + Vector.Subtract(a, b));
Console.WriteLine("Произведение векторов \"a\" и \"b\" = " + Vector.Multiply(a, b));