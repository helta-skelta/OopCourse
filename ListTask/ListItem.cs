
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

        public static bool Compare(T? data1, T? data2)
        {
            return EqualityComparer<T>.Default.Equals(data1, data2);
        }
    }
}
