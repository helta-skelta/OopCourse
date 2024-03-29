﻿using System.Collections;

namespace HashTableTask
{
    internal class HashTable<T> : ICollection<T>
    {
        private LinkedList<Item<T>>[] hashTable;

        private const int Capacity = 10;

        private int count;

        public HashTable()
        {
            hashTable = new LinkedList<Item<T>>[Capacity];
        }

        public HashTable(int capacity)
        {
            hashTable = new LinkedList<Item<T>>[capacity];
        }

        public int Count
        {
            get => count;

            private set
            {
                if (Count == hashTable.Length)
                {
                    var newHashTable = new LinkedList<Item<T>>[Capacity * 2];

                    hashTable.CopyTo(newHashTable, 0);

                    hashTable = newHashTable;
                }

                count = value;
            }
        }

        public bool IsReadOnly => false;

        public void Add(T item)
        {
            if (IsReadOnly)
            {
                throw new NotSupportedException("Коллекция доступна только для чтения.");
            }

            if (item is null)
            {
                throw new ArgumentNullException(nameof(item), $"Добавляемый элемент {item} null.");
            }

            var newItem = new Item<T>(item);

            int index = Math.Abs(newItem.GetHashCode() % hashTable.Length);

            if (hashTable[index] is null)
            {
                hashTable[index] = new LinkedList<Item<T>>();
                hashTable[index].AddFirst(newItem);

                ++Count;
            }
            else
            {
                hashTable[index].AddFirst(newItem);
            }
        }

        public void Clear()
        {
            if (IsReadOnly)
            {
                throw new NotSupportedException("Коллекция доступна только для чтения.");
            }

            if (count == 0)
            {
                throw new InvalidOperationException("Коллекция пустая.");
            }

            for (int i = 0, j = hashTable.Length - 1; i < j; ++i, --j)
            {
                hashTable[i] = null!;
                hashTable[j] = null!;
            }
        }

        public bool Contains(T item)
        {
            foreach (T element in this)
            {
                if (Equals(element, item))
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
                throw new ArgumentOutOfRangeException(nameof(arrayIndex), $"Индекс {arrayIndex} не может быть меньше 0.");
            }

            if (Count > array.Length)
            {
                throw new ArgumentException($"Число элементов в исходной коллекции больше доступного места от положения, " +
                    $"заданного значением параметра {arrayIndex}, до конца массива назначения {array}.");
            }

            foreach (T item in this)
            {
                array[arrayIndex] = item;

                ++arrayIndex;
            }
        }

        public bool Remove(T item)
        {
            if (IsReadOnly)
            {
                throw new NotSupportedException("Коллекция доступна только для чтения.");
            }

            if (item is null)
            {
                throw new ArgumentNullException(nameof(item), $"Обьект {item} равен null.");
            }

            if (count == 0)
            {
                throw new InvalidOperationException("Коллекция пустая.");
            }

            Item<T> x = new(item);

            for (int i = 0; i < hashTable.Length; ++i)
            {
                if (hashTable[i] is null)
                {
                    continue;
                }

                if (hashTable[i].Contains(x))
                {
                    return hashTable[i].Remove(x);
                }
            }

            return false;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<T> GetEnumerator()
        {
            int count = this.count;

            for (int i = 0; i < hashTable.Length; ++i)
            {
                if (count != this.count)
                {
                    throw new Exception("Коллекция изменилась.");
                }

                if (hashTable[i] is null)
                {
                    continue;
                }

                IEnumerator<Item<T>> iterator = hashTable[i].GetEnumerator();

                while (iterator.MoveNext())
                {
                    yield return iterator.Current.Value!;
                }
            }
        }
    }
}