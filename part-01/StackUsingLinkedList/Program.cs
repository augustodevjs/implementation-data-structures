namespace StackUsingLinkedList;

public class Program
{
    static void Main(string[] args)
    {
        var stack = new Stack<int>();

        stack.Push(10);
        stack.Push(20);
        stack.Push(30);

        Console.WriteLine($"Stack size: {stack.Size}");

        Console.WriteLine($"Removed element: {stack.Pop()}");
        Console.WriteLine($"Removed element: {stack.Pop()}");

        Console.WriteLine($"Stack size: {stack.Size}");

        Console.WriteLine($"Removed element: {stack.Pop()}");

        Console.WriteLine($"Is the stack empty? {stack.IsEmpty()}");
    }
}