using System.Text;
using System.Numerics;
using Vector = VectorTask.Vector;

namespace MatrixTask
{
    internal class Matrix
    {
        private double[,] mass;

        public double[,] Mass
        {
            get => mass;

            set
            {
                if (value is null)
                {
                    throw new ArgumentNullException(nameof(value), "Матрицы равна null");
                }

                if (value.GetLength(0) < 2)
                {
                    throw new ArgumentException("Высота матрицы не может быть меньше двух.", nameof(value));
                }

                if (value.GetLength(1) < 2)
                {
                    throw new ArgumentException("Ширина матрицы не может быть меньше двух.", nameof(value));
                }

                mass = value;
            }
        }

        public double this[int height, int weight]
        {
            get => mass[height, weight];

            set => mass[height, weight] = value;
        }

        public Matrix(int height, int width)
        {
            Mass = new double[height, width];
        }

        public Matrix(double[,] matrix) : this(matrix.GetLength(0), matrix.GetLength(1))
        {
            for (int i = 0; i < matrix.GetLength(0); ++i)
            {
                for (int j = 0; j < matrix.GetLength(1); ++j)
                {
                    mass![i, j] = matrix[i, j];
                }
            }
        }

        public Matrix(Vector[] vektor)
        {
            if (vektor is null)
            {
                throw new ArgumentNullException(nameof(vektor), "Вектор равен null");
            }

            int width = vektor[0].GetSize < vektor[1].GetSize ? vektor[1].GetSize : vektor[0].GetSize;
            int height = vektor.Length;

            for (int i = 1; i < vektor.Length - 1; ++i)
            {
                width = width < vektor[i + 1].GetSize ? vektor[i + 1].GetSize : width;
            }

            Mass = new double[height, width];

            for (int i = 0; i < height; ++i)
            {
                for (int j = 0; j < vektor[i].GetSize; ++j)
                {
                    mass![i, j] = vektor[i][j];
                }
            }
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append('[');

            for (int i = 0; i < mass.GetLength(0); ++i)
            {
                stringBuilder.Append('(');
                stringBuilder.AppendJoin(", ", GetRow(i));
                stringBuilder.Append(')');
                stringBuilder.Append(", ");
            }

            stringBuilder.Remove(stringBuilder.Length - 2, 2);
            stringBuilder.Append(']');

            return $"{stringBuilder}";
        }

        private double[] GetRow(int rowIndex)
        {
            if (rowIndex < 0 || rowIndex > mass.GetLength(0))
            {
                throw new ArgumentOutOfRangeException(nameof(rowIndex), "Недопустимое значение аргумента, строки под таким индексом нет.");
            }

            double[] matrixRow = new double[GetWidth];

            for (int i = 0; i < mass.GetLength(1); ++i)
            {
                matrixRow[i] = mass[rowIndex, i];
            }

            return matrixRow;
        }

        private double[] GetColoumn(int coloumnIndex)
        {
            if (coloumnIndex < 0 || coloumnIndex > mass!.GetLength(1))
            {
                throw new ArgumentOutOfRangeException(nameof(coloumnIndex), "Недопустимое значение аргумента, столбца под таким индексом нет.");
            }

            double[] matrixColoumn = new double[GetHeight];

            for (int i = 0; i < mass.GetLength(0); ++i)
            {
                matrixColoumn[i] = mass[i, coloumnIndex];
            }

            return matrixColoumn;
        }

        public int GetHeight
        {
            get => mass.GetLength(0);
        }

        public int GetWidth
        {
            get => mass.GetLength(1);
        }

        public Vector GetVectorRow(int rowIndex)
        {
            if (rowIndex < 0 || rowIndex > mass.GetLength(0))
            {
                throw new ArgumentOutOfRangeException(nameof(rowIndex), "Недопустимое значение аргумента, строки под таким индексом нет.");
            }

            return new(GetRow(rowIndex));
        }

        public void SetVectorRow(Vector vector, int rowIndex)
        {
            if (vector is null)
            {
                throw new ArgumentNullException(nameof(vector), "Вектор равен null");
            }

            if (rowIndex < 0 || rowIndex > mass.GetLength(0))
            {
                throw new ArgumentOutOfRangeException(nameof(rowIndex), "Недопустимое значение аргумента, строки под таким индексом нет.");
            }

            if (vector.GetSize > mass.GetLength(1))
            {
                Resize(mass.GetLength(0), vector.GetSize);
            }

            for (int i = 0; i < vector.GetSize; ++i)
            {
                mass[rowIndex, i] = vector[i];
            }
        }

        public Vector GetVectorColoumn(int coloumnIndex)
        {
            if (coloumnIndex < 0 || coloumnIndex > mass.GetLength(1))
            {
                throw new ArgumentOutOfRangeException(nameof(coloumnIndex), "Недопустимое значение аргумента, столбца под таким индексом нет.");
            }

            return new(GetColoumn(coloumnIndex));
        }

        public Matrix Transposition()
        {
            Matrix transpositionMatrix = new(GetWidth, GetHeight);

            for (int i = 0; i < transpositionMatrix.GetHeight; ++i)
            {
                double[] row = GetColoumn(i);

                for (int j = 0; j < transpositionMatrix.GetWidth; ++j)
                {
                    transpositionMatrix[i, j] = row[j];
                }
            }

            return transpositionMatrix;
        }

        public void ScalarMultiply(double factor)
        {
            for (int i = 0; i < mass.GetLength(0); ++i)
            {
                for (int j = 0; j < mass.GetLength(1); ++j)
                {
                    mass[i, j] *= factor;
                }
            }
        }

        public double Determinant()
        {
            Matrix matrix = new(mass.GetLength(0), mass.GetLength(1));
            Array.Copy(mass, matrix.mass, mass.Length);

            if (GetWidth != GetHeight)
            {
                throw new ArgumentException("Матрица должна быть квадратной.", nameof(mass));
            }

            Vector currentMatrixRow = new(GetHeight);
            int matrixSize = currentMatrixRow.GetSize;
            double determinant = 1;
            const double epsilon = 1.0e-10;

            for (int i = 0; i < matrixSize; ++i)
            {
                currentMatrixRow = matrix.GetVectorColoumn(i);

                if (Math.Abs(currentMatrixRow[i]) <= epsilon) //если в главной диагонали элемент [i,i] равен 0, 
                {
                    int j = i + 1;

                    while (j < matrixSize)
                    {
                        if (Math.Abs(currentMatrixRow[j]) > epsilon || Math.Abs(currentMatrixRow[j]) < epsilon)//при условии что элемент [j,i] не равен 0.
                        {
                            currentMatrixRow = matrix.GetVectorRow(j);
                            matrix.SetVectorRow(GetVectorRow(i), j); //меняем местами строки i и j,
                            matrix.SetVectorRow(currentMatrixRow, i);

                            break;
                        }

                        ++j;
                    }

                    if (j == currentMatrixRow.GetSize)
                    {
                        return 0;
                    }
                }

                for (int k = i + 1; k < matrixSize; ++k)
                {
                    currentMatrixRow = matrix.GetVectorRow(i);
                    currentMatrixRow.MultiplyByScalar(-matrix[k, i] / matrix[i, i]);
                    currentMatrixRow.Add(matrix.GetVectorRow(k));                           //приводим матрицу к верхнетреугольному виду.
                    matrix.SetVectorRow(currentMatrixRow, k);
                }

                determinant *= matrix[i, i];
            }

            return Math.Round(determinant, MidpointRounding.AwayFromZero);
        }

        public void MultiplyByVector(Vector vector)
        {
            if (vector is null)
            {
                throw new ArgumentNullException(nameof(vector), "Вектор равен null");
            }

            int length = Math.Min(vector.GetSize, mass.GetLength(1));

            for (int i = 0; i < mass.GetLength(0); ++i)
            {
                for (int j = 0; j < length; ++j)
                {
                    mass[i, j] *= vector[j];
                }
            }
        }

        public void Add(Matrix matrix)
        {
            if (matrix is null)
            {
                throw new ArgumentNullException(nameof(matrix), "Матрица равна null");
            }

            if (matrix.mass.GetLength(0) > mass.GetLength(0) && matrix.mass.GetLength(1) > mass.GetLength(1))
            {
                Resize(matrix.mass.GetLength(0), matrix.mass.GetLength(1));
            }

            if (matrix.mass.GetLength(0) > mass.GetLength(0))
            {
                Resize(matrix.mass.GetLength(0), mass.GetLength(1));
            }

            if (matrix.mass.GetLength(1) > mass.GetLength(1))
            {
                Resize(mass.GetLength(0), matrix.mass.GetLength(1));
            }

            for (int i = 0; i < matrix.mass.GetLength(0); ++i)
            {
                for (int j = 0; j < matrix.mass.GetLength(1); ++j)
                {
                    mass[i, j] += matrix[i, j];
                }
            }
        }

        public void Subtract(Matrix matrix)
        {
            if (matrix is null)
            {
                throw new ArgumentNullException(nameof(matrix), "Матрица равна null");
            }

            int height = Math.Min(matrix.mass.GetLength(0), mass.GetLength(0));
            int width = Math.Min(matrix.mass.GetLength(1), mass.GetLength(1));

            for (int i = 0; i < height; ++i)
            {
                for (int j = 0; j < width; ++j)
                {
                    mass[i, j] -= matrix[i, j];
                }
            }
        }

        private void Resize(int height, int width)
        {
            double[,] newMatrix = new double[height, width];

            int newHeight = newMatrix.GetLength(0) > mass!.GetLength(0) ? mass.GetLength(0) : height;
            int newWidth = newMatrix.GetLength(1) > mass!.GetLength(1) ? mass.GetLength(1) : width;

            for (int i = 0; i < newHeight; ++i)
            {
                for (int j = 0; j < newWidth; ++j)
                {
                    newMatrix[i, j] = mass[i, j];
                }
            }

            mass = newMatrix;
        }

        public static Matrix GetSum(Matrix matrix1, Matrix matrix2)
        {
            if (matrix1 is null)
            {
                throw new ArgumentNullException(nameof(matrix1), "Матрица1 равна null");
            }

            if (matrix2 is null)
            {
                throw new ArgumentNullException(nameof(matrix2), "Матрица2 равна null");
            }

            Matrix sumMatrix = new(matrix1.mass);

            sumMatrix.Add(matrix2);

            return sumMatrix;
        }

        public static Matrix GetDifference(Matrix matrix1, Matrix matrix2)
        {
            if (matrix1 is null)
            {
                throw new ArgumentNullException(nameof(matrix1), "Матрица1 равна null");
            }

            if (matrix2 is null)
            {
                throw new ArgumentNullException(nameof(matrix2), "Матрица2 равна null");
            }

            Matrix differenceMatrix = new(matrix1.mass);

            differenceMatrix.Subtract(matrix2);

            return differenceMatrix;
        }

        public static Matrix GetProduct(Matrix matrix1, Matrix matrix2)
        {
            if (matrix1 is null)
            {
                throw new ArgumentNullException(nameof(matrix1), "Матрица1 равна null");
            }

            if (matrix2 is null)
            {
                throw new ArgumentNullException(nameof(matrix2), "Матрица2 равна null");
            }

            if (matrix1.mass.GetLength(1) != matrix2.mass.GetLength(0))
            {
                throw new ArgumentException("Матрицы не совместимы, число столбцов первой матрицы должно быть равно числу строк второй матрицы");
            }

            Matrix productMatrix = new(matrix1.mass.GetLength(0), matrix2.mass.GetLength(1));

            for (int i = 0; i < matrix1.mass.GetLength(0); ++i)
            {
                for (int j = 0; j < matrix2.mass.GetLength(1); ++j)
                {
                    productMatrix[i, j] = Vector.GetDotProduct(matrix1.GetVectorRow(i), matrix2.GetVectorColoumn(j));
                }
            }

            return productMatrix;
        }
    }
}