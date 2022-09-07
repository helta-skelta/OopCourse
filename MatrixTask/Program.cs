using VectorTask;
using MatrixTask;

double[,] array =
{
    {2, 6, 7},
    {3, 4, 8},
    {9, 6, 2},
    {3, 5, 4}
};

Matrix matrix1 = new(array);

double[] components1 = { 3, 5, 6, 7 };
double[] components2 = { 1, 2, 3, 8 };
double[] components3 = { 4, 5, 6, 7 };
double[] components4 = { 1, 2, 3, 4 };
double[] components5 = { 4, 5, 6, 7, 5, 8 };

Vector vector1 = new(components1);
Vector vector2 = new(components2);
Vector vector3 = new(components3);
Vector vector4 = new(components4);
Vector vector5 = new(components5);

Vector[] vectorsArray = new[] { vector1, vector2, vector3, vector4 };

Matrix matrix2 = new(vectorsArray);

Console.WriteLine($"Высота матрицы = {matrix1.GetHeight}. Ширина матрицы matrix1 = {matrix1.GetWidth}.");

matrix1.SetVectorRow(vector5, 1);
Console.WriteLine($"Строка матрицы matrix1 под индексом 1 = {matrix1.GetVectorRow(1)}.");

Console.WriteLine($"Столбец матрицы matrix1 под индексом 0 = {matrix1.GetVectorRow(0)}.");

Console.WriteLine($"Транспонирование матрицы matrix1 = {matrix1.Transposition()}.");

matrix1.ScalarMultiply(5);
Console.WriteLine($"Умножение матрицы matrix1 на 5 = {matrix1}.");

Console.WriteLine($"Определитель матрицы matrix2 = {matrix2.Determinant()}.");

matrix1.MultiplyByVector(vector4);
Console.WriteLine($"Умножение матрицы matrix1 на вектор vector4 = {matrix1}");

matrix1.Add(matrix2);
Console.WriteLine($"Прибавление к матрице matrix1 матрицы matrix2 = {matrix1}");

matrix1.Subtract(matrix2);
Console.WriteLine($"Вычитание из матрицы matrix1 матрицы matrix2 = {matrix1}");

Console.WriteLine($"Сумма матриц matrix1 и matrix2 = {Matrix.GetSum(matrix1, matrix2)}");

Console.WriteLine($"Разность матриц matrix1 и matrix2 = {Matrix.GetDifference(matrix1, matrix2)}");

Matrix matrix3 = new(array);

Console.WriteLine($"Произведение матриц matrix2 и matrix3 = {Matrix.GetProduct(matrix2, matrix3)}");