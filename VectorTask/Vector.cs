namespace VectorTask
{
    public class Vector
    {
        private double[] components;

        public double this[int index]
        {
            get => components[index];
            set => components[index] = value;
        }

        public Vector(int vectorLength)
        {
            components = vectorLength <= 0 ? throw new ArgumentException("Длина вектора равна 0", nameof(vectorLength)) : new double[vectorLength];
        }

        public Vector(Vector vector)
        {
            if (vector is null)
            {
                throw new ArgumentNullException(nameof(vector), "Вектор равен null");
            }

            components = vector.GetSize() <= 0 ? throw new ArgumentException("Длина вектора равна 0", nameof(vector)) : new double[vector.GetSize()];

            Array.Copy(vector.components, components, vector.GetSize());
        }

        public Vector(double[] components)
        {
            if (components is null)
            {
                throw new ArgumentNullException(nameof(components), "Вектор равен null");
            }

            this.components = components.Length <= 0 ? throw new ArgumentException("Длина вектора равна 0", nameof(components)) : new double[components.Length];

            Array.Copy(components, this.components, components.Length);
        }

        public Vector(int vectorLength, double[] components)
        {
            if (components is null)
            {
                throw new ArgumentNullException(nameof(components), "Вектор равен null");
            }

            this.components = vectorLength <= 0 ? throw new ArgumentException("Длина вектора равна 0", nameof(vectorLength)) : new double[vectorLength];

            Array.Copy(components, this.components!, components.Length);
        }

        public int GetSize() => components.Length;

        public override string ToString()
        {
            return $"{{{string.Join(", ", components)}}}";
        }

        public void Add(Vector vector)
        {
            if (vector is null)
            {
                throw new ArgumentNullException(nameof(vector), "Вектор равен null");
            }

            if (components.Length < vector.components.Length)
            {
                Array.Resize(ref components, vector.components.Length);
            }

            for (int i = 0; i < vector.GetSize(); ++i)
            {
                components[i] += vector[i];
            }
        }

        public void Subtract(Vector vector)
        {
            if (vector is null)
            {
                throw new ArgumentNullException(nameof(vector), "Вектор равен null");
            }

            if (components.Length < vector.components.Length)
            {
                Array.Resize(ref components, vector.components.Length);
            }

            for (int i = 0; i < vector.GetSize(); ++i)
            {
                components[i] -= vector[i];
            }
        }

        public void MultiplyByScalar(double factor)
        {
            for (int i = 0; i < components.Length; ++i)
            {
                components[i] *= factor;
            }
        }

        public void Reverse()
        {
            MultiplyByScalar(-1);
        }

        public double GetLength()
        {
            double componentsSquaredSum = 0;

            foreach (double component in components)
            {
                componentsSquaredSum += component * component;
            }

            return Math.Sqrt(componentsSquaredSum);
        }

        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(obj, this))
            {
                return true;
            }

            if (obj is null || obj.GetType() != GetType())
            {
                return false;
            }

            Vector vector = (Vector)obj;

            return Enumerable.SequenceEqual(components, vector.components);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            const int prime = 31;

            if (components != null)
            {
                foreach (double component in components)
                {
                    hash = prime * hash + component.GetHashCode();
                }

                return hash;
            }

            return 0;
        }

        public static Vector GetSum(Vector vector1, Vector vector2)
        {
            if (vector1 is null)
            {
                throw new ArgumentNullException(nameof(vector1), "Вектор1 равен null");
            }

            if (vector2 is null)
            {
                throw new ArgumentNullException(nameof(vector2), "Вектор2 равен null");
            }

            Vector result = new(vector1);

            result.Add(vector2);

            return result;
        }

        public static Vector GetDifference(Vector vector1, Vector vector2)
        {
            if (vector1 is null)
            {
                throw new ArgumentNullException(nameof(vector1), "Вектор1 равен null");
            }

            if (vector2 is null)
            {
                throw new ArgumentNullException(nameof(vector2), "Вектор2 равен null");
            }

            Vector result = new(vector1);

            result.Subtract(vector2);

            return result;
        }

        public static double GetDotProduct(Vector vector1, Vector vector2)
        {
            if (vector1 is null)
            {
                throw new ArgumentNullException(nameof(vector1), "Вектор1 равен null");
            }

            if (vector2 is null)
            {
                throw new ArgumentNullException(nameof(vector2), "Вектор2 равен null");
            }

            int smallerVector = Math.Min(vector1.GetSize(), vector2.GetSize());
            double result = 0;

            for (int i = 0; i < smallerVector; ++i)
            {
                result += vector1[i] * vector2[i];
            }

            return result;
        }
    }
}