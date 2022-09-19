using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;

namespace ListTask
{
    internal class SinglyLinkedList<T>
    {
        private int count;

        private ListItem<T>? Head { get; set; }

        public int Count => count;

        public SinglyLinkedList() { }

        public SinglyLinkedList(T headData)
        {
            Head = new ListItem<T>(headData);

            ++count;
        }

        public T FirstElementValue()
        {
            if (Head is null)
            {
                throw new InvalidOperationException("Список пустой.");
            }

            return Head.Data;
        }

        public ListItem<T> this[int index]
        {
            get
            {
                if (Head is null)
                {
                    throw new InvalidOperationException("Список пустой.");
                }

                if (index < 0 || index >= Count)
                {
                    throw new ArgumentOutOfRangeException(nameof(index), "Выход за границу списка.");
                }

                ListItem<T> indexElement = Head;

                for (int i = 0; i < index && indexElement.Next != null; ++i)
                {
                    indexElement = indexElement.Next;
                }

                return indexElement;
            }
        }

        public T GetSetIndexValue(int index)
        {
            return this[index].Data;
        }

        public T GetSetIndexValue(T newIndexElementValue, int index)
        {
            T currentIndexValue = this[index].Data;

            this[index].Data = newIndexElementValue;

            return currentIndexValue;
        }

        public T DeleteIndexElement(int index)
        {
            if (index < 0 || index >= Count)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Выход за границу списка, такого элемента нет.");
            }

            if (index == 0)
            {
                T headValue = Head!.Data;

                Head = Head.Next;

                return headValue;
            }

            T removedElementValue = this[index].Data;

            this[index - 1].Next = this[index].Next;

            --count;

            return removedElementValue;
        }

        public void AddFirst(T value)
        {
            if (value is null)
            {
                throw new ArgumentNullException(nameof(value), $"Значение {value} равно null.");
            }

            ListItem<T> firstElement = new(value)
            {
                Next = Head
            };

            Head = firstElement;

            ++count;
        }

        public void AddToIndex(T value, int index)
        {
            if (value is null)
            {
                throw new ArgumentNullException(nameof(value), $"Значение {value} равно null.");
            }

            if (index < 0 || index >= Count)
            {
                throw new ArgumentOutOfRangeException(nameof(index), $"Значение {index} вне диапазона.");
            }

            if (index == 0)
            {
                AddFirst(value);
            }

            ListItem<T> newElement = new(value)
            {
                Next = this[index]
            };

            this[index - 1].Next = newElement;

            ++count;
        }

        public bool DeleteValue(T value)
        {
            if (value is null)
            {
                throw new ArgumentNullException(nameof(value), $"Значение {value} равно null.");
            }

            ListItem<T> a = new(value);
            bool isDelete = false;

            for (int i = 0; i < count; ++i)
            {
                if (ListItem<T>.Compare(a.Data, this[i].Data))
                {
                    DeleteIndexElement(i);
                    isDelete = true;

                    --count;
                }
            }

            return isDelete;
        }

        public T DeleteFirst()
        {
            return DeleteIndexElement(0);
        }

        public void Reverse()
        {
            if (Head is null)
            {
                throw new InvalidOperationException("Список пустой.");
            }

            if (count == 1)
            {
                throw new InvalidOperationException("Список состоит из одного элемента, разворот списка не возможен.");
            }

            this[count - 1].Next = Head;
            ListItem<T> firstElement = Head;
            Head = this[count - 1];

            for (int i = 0; firstElement != this[count - 1]; ++i)
            {
                this[i].Next = this[count - 1];
                this[i + 1].Next = firstElement;
            }

            this[count - 1].Next = null;
        }

        public static SinglyLinkedList<T> Copy(SinglyLinkedList<T> sourceList)
        {
            if (sourceList is null)
            {
                throw new ArgumentNullException(nameof(sourceList), $"Список {sourceList} равен null.");
            }

            if (sourceList.count == 0)
            {
                throw new InvalidOperationException($"Список {sourceList} пустой, операция не возможна.");
            }

            SinglyLinkedList<T> destinationList = new();

            for (int i = sourceList.count - 1; i >= 0; --i)
            {
                destinationList.AddFirst(sourceList[i].Data);
            }

            return destinationList;
        }
    }
}