namespace DynamicArray;

public class Program
{
    static void Main(string[] args)
    {
        var array = new DynamicArray<int>();

        array.PushBack(10);
        array.PushBack(20);
        array.PushBack(30);

        int insertPosition = 1;
        int insertValue = 99;
        Console.WriteLine($"\nInserting value {insertValue} " +
            $"at position {insertPosition}...");
        array.Insert(insertPosition, insertValue);

        int searchValue = 20;
        int foundIndex = array.Search(searchValue);
        Console.WriteLine($"Value {searchValue} found at index {foundIndex}");

        int removePosition = 2;
        Console.WriteLine($"\nRemoving element at position {removePosition}...");
        array.RemoveAt(removePosition);
    }
}
