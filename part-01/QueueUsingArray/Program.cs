namespace QueueUsingArray;

public class Program
{
    static void Main(string[] args)
    {
        var queue = new Queue<int>();

        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);
        queue.Enqueue(40);
        queue.Enqueue(50);

        Console.WriteLine($"Dequeued element: {queue.Dequeue()}");
        Console.WriteLine($"Dequeued element: {queue.Dequeue()}");

        Console.WriteLine($"Is the queue empty? {queue.IsEmpty()}");

        queue.Enqueue(60);
        queue.Enqueue(70);

        Console.WriteLine($"Dequeued element: {queue.Dequeue()}");
        Console.WriteLine($"Dequeued element: {queue.Dequeue()}");
        Console.WriteLine($"Dequeued element: {queue.Dequeue()}");

        Console.WriteLine($"Is the queue empty? {queue.IsEmpty()}");
    }
}
