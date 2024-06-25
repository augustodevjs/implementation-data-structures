namespace Queue;

public class Program
{
    static void Main(string[] args)
    {
        Queue queue = new Queue();
        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);

        queue.Print(); 

        Console.WriteLine(queue.Dequeue());
        queue.Print(); 

        Console.WriteLine(queue.Dequeue()); 
        queue.Print();  

        Console.WriteLine(queue.Dequeue()); 
        queue.Print();
    }
}
