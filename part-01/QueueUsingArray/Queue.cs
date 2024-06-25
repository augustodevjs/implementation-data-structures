namespace QueueUsingArray;

public class Queue<T>
{
    private T[] array;
    private int front;
    private int rear;
    private int capacity;
    private const int DefaultCapacity = 5;

    public Queue(int initialCapacity = DefaultCapacity)
    {
        array = new T[initialCapacity];
        capacity = initialCapacity;
        front = 0;
        rear = -1;
    }

    public void Enqueue(T element)
    {
        if (IsFull())
        {
            ResizeArray();
        }

        rear = (rear + 1) % capacity;
        array[rear] = element;
    }

    public T Dequeue()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Queue is empty");
        }

        T dequeuedElement = array[front];
        array[front] = default;
        front = (front + 1) % capacity;
        return dequeuedElement;
    }

    public bool IsEmpty()
    {
        return front == (rear + 1) % capacity;
    }

    private bool IsFull()
    {
        return (rear + 1) % capacity == front;
    }

    private void ResizeArray()
    {
        int newCapacity = capacity * 2;
        T[] newArray = new T[newCapacity];

        int currentSize = Size();

        for (int i = 0; i < currentSize; i++)
        {
            newArray[i] = array[(front + i) % capacity];
        }

        array = newArray;
        front = 0;
        rear = currentSize - 1;
        capacity = newCapacity;
    }

    public int Size()
    {
        if (rear >= front)
            return rear - front + 1;
        else
            return capacity - front + rear + 1;
    }
}