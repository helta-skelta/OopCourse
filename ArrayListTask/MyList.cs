using System.Collections;

namespace ArrayListTask
{
    internal class MyList<T> : IList<T>
    {
        private T?[] elements = new T[10];
        private int count = 0;

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= count)
                {
                    throw new ArgumentOutOfRangeException(nameof(index));
                }

                return elements[index]!;
            }

            set
            {
                if (index < 0 || index >= count)
                {
                    throw new ArgumentOutOfRangeException(nameof(index));
                }

                elements[index] = value;
            }
        }

        public int Capacity
        {
            get => elements.Length;
            set
            {
                if (value < count)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), $"Вместимость списка {Capacity} не может быть меньше, количества элементов.");
                }

                elements = new T[value];
            }
        }

        public int Count => count;

        public MyList() { }

        public MyList(IEnumerable<T> collection) : this(collection.Count())
        {
            IEnumerator<T> enumerator = collection.GetEnumerator();

            for (int i = 0; enumerator.MoveNext(); ++i)
            {
                elements[i] = enumerator.Current;
                ++count;
            }
        }

        public MyList(int capacity)
        {
            Capacity = capacity;
        }

        public bool IsReadOnly => false;

        public void TrimExcess()
        {
            if (Capacity > count)
            {
                T[] array = new T[count];

                Array.Copy(elements, array, count);

                elements = array;
            }
        }

        public void Add(T item)
        {
            if (item is null)
            {
                throw new ArgumentNullException(nameof(item), $"Добавляемый элемент {item} равен null.");
            }

            if (count >= elements.Length)
            {
                IncreaseCapacity();
            }

            elements[count] = item;
            ++count;
        }

        public void Clear()
        {
            elements = new T[10];
            count = 0;
        }

        public bool Contains(T item)
        {
            foreach (T? items in elements)
            {
                if (EqualityComparer<T>.Default.Equals(items, item))
                {
                    return true;
                }
            }

            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array), $"Массив {array} равен null.");
            }

            if (arrayIndex < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(arrayIndex), $"Индекс массива не может быть менеьше 0.");
            }

            if (count > array.Length - arrayIndex)
            {
                throw new ArgumentException("Число элементов в исходной коллекции больше доступного места," +
                    " от положения заданного значением параметра arrayIndex, до конца массива назначения array.");
            }

            Array.Copy(elements, 0, array, arrayIndex, Count);
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; ++i)
            {
                yield return elements[i]!;
            }
        }

        public int IndexOf(T item)
        {
            if (item is null)
            {
                throw new ArgumentNullException(nameof(item), $"Массив {item} равен null.");
            }

            return Array.IndexOf(elements, item);
        }

        public void Insert(int index, T item)
        {
            if (index < 0 || index > count)
            {
                throw new ArgumentOutOfRangeException(nameof(index), $"Индекс вставляемого элемента не может быть менеьше 0 или больше count.");
            }

            if (count == Capacity)
            {
                IncreaseCapacity();
            }

            Array.Copy(elements, index, elements, index + 1, count - index);

            elements[index] = item;
            ++count;
        }

        public bool Remove(T item)
        {
            for (int i = 0; i < count; ++i)
            {
                if (EqualityComparer<T>.Default.Equals(item, elements[i]))
                {
                    Array.Copy(elements, i + 1, elements, i, count - i - 1);

                    elements[count - 1] = default;
                    --count;

                    return true;
                }
            }

            return false;
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new ArgumentOutOfRangeException(nameof(index), $"Индекс удаляемого элемента не может быть менеьше 0 или большим или равным count.");
            }

            Array.Copy(elements, index + 1, elements, index, count - index - 1);

            elements[count - 1] = default;
            --count;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private void IncreaseCapacity()
        {
            Array.Resize(ref elements, elements.Length * 2);
        }
    }
}
