namespace HashTableTask
{
    internal record Item<T>
    {
        public T? Value { get; init; }

        public Item(T value)
        {
            if (value is null)
            {
                throw new ArgumentNullException(nameof(value), $"Значение {value} равно null.");
            }

            Value = value;
        }
    }
}