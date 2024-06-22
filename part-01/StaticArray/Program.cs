namespace StaticArray;

public class Program
{
    static void Main(string[] args)
    {
        int capacity = 10;
        int[] arr = new int[capacity];
        int length = 0;

        var staticArray = new StaticArray();

        staticArray.InsertEnd(arr, 5, ref length, capacity);
        staticArray.InsertEnd(arr, 10, ref length, capacity);

        int elementAtIndex1 = arr[1];
        Console.WriteLine($"Elemento no índice 1: {elementAtIndex1}");

        staticArray.InsertMiddle(arr, 1, 7, ref length);

        int target = 7;
        int index = staticArray.Search(arr, length, target);

        Console.WriteLine(index);

        staticArray.RemoveEnd(arr, ref length);

        staticArray.RemoveMiddle(arr, 0, ref length);
    }
}
