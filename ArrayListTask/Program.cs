using ArrayListTask;

MyList<string> list = new()
{
    "1",
    "2",
    "3",
    "4",
    "5",
    "6"
};

int x = list.Count;

MyList<string> list2 = new(list)
{
    "7"
};

Console.WriteLine($"Вместимость списка list2 = {list2.Capacity}.");
Console.WriteLine($"Количество элементов списка list2 = {list2.Count}.");

list2.TrimExcess();

list2.Add("8");

list.Clear();

Console.WriteLine($"Содержит ли список list элемент \"1\": {list.Contains("1")}");
Console.WriteLine($"Содержит ли список list2 элемент \"1\": {list2.Contains("1")}");

string[] strings = new string[10];

list2.CopyTo(strings, 0);

list2.Insert(0, "9");
Console.WriteLine($"Индекс элемента \"9\" в списке list2 = {list2.IndexOf("9")}.");

list2.Remove("9");
list2.RemoveAt(0);

Console.WriteLine("Список list2: ");

foreach (string e in list2)
{
    Console.WriteLine(e);
}