using HashTableTask;

HashTable<string> hashTable = new() { "Banana", "Apple", "Lemon", "Mango", "Peach", "Melon" };

foreach (string fruit in hashTable)
{
    Console.WriteLine(fruit);
}

Console.WriteLine();

string[] array = new string[6];
hashTable.CopyTo(array, 0);

Console.WriteLine(string.Join(", ", array));
Console.WriteLine();

bool isRemoove = hashTable.Remove("Banana");

foreach (string e in hashTable)
{
    Console.WriteLine(e);
}

bool isContains = hashTable.Contains("Melon");

hashTable.Clear();