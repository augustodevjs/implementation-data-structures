namespace StackUsingArray;

public class Program
{
    static void Main(string[] args)
    {
        var stack = new Stack<int>();

        stack.Push(10);
        stack.Push(20);
        stack.Push(30);
        stack.Push(40);
        stack.Push(50);
        stack.Push(60);

        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Pop());

        Console.WriteLine("Is the stack empty? " + stack.IsEmpty());

        stack.Push(70);
        stack.Push(80);

        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Pop());

        Console.WriteLine("Is the stack empty? " + stack.IsEmpty());
    }
}
