using System.Collections.Generic;
using System.Numerics;

namespace ListTask
{
    internal class ListItem<T>
    {
        public T Data { get; set; }
        public ListItem<T>? Next { get; set; }

        public ListItem(T data)
        {
            if (data is null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            Data = data;
        }

        public ListItem(T data, ListItem<T> next) : this(data)
        {
            Next = next;
        }

        public static bool Compare(T? x, T? y)
        {
            return EqualityComparer<T>.Default.Equals(x, y);
        }
    }
}
