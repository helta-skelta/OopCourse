using ListTask;

SinglyLinkedList<string> list1 = new("5");
list1.AddFirst("4");
list1.AddFirst("3");
list1.AddFirst("2");
list1.AddFirst("1");

Console.WriteLine($"Размер списка list = {list1.Count}. Значение первого элемента = {list1.FirstElementValue()}.");
Console.WriteLine();

list1.AddToIndex("6", 2);
Console.WriteLine($"Добавили элемент по индексу \"2\".");

Console.WriteLine($"Значение элемента под индексом \"2\" = {list1.GetSetIndexValue(2)}.");

Console.WriteLine($"Установили элемент по значению по индексу \"2\" =  {list1.GetSetIndexValue("3", 2)}.");

Console.WriteLine($"Удаляем элемент под индексом \"0\" = {list1.DeleteIndexElement(0)}.");

Console.WriteLine($"Удаляем элемент по значению \"3\" = {list1.DeleteValue("3")}.");

SinglyLinkedList<string> list2 = new("1");
list2.AddFirst("2");
list2.AddFirst("3");
list2.AddFirst("4");
list2.AddFirst("5");
list2.AddFirst("6");

Console.WriteLine();

Console.WriteLine("Элементы списка list2:");

for (int i = 0; i < list2.Count; ++i)
{
    Console.WriteLine(list2[i].Data);
}

Console.WriteLine();

list2.Reverse();

Console.WriteLine("Развернули список list2: ");

for (int i = 0; i < list2.Count; ++i)
{
    Console.WriteLine(list2[i].Data);
}

Console.WriteLine();

Console.WriteLine("Копируем список list2 в list3: ");

SinglyLinkedList<string> list3 = SinglyLinkedList<string>.Copy(list2);

for (int i = 0; i < list3.Count; ++i)
{
    Console.WriteLine(list3[i].Data);
}