namespace StackUsingLinkedList;

public class Stack<T>
{
    private Node<T> top;
    private int size = 0;

    public int Size => size;

    public bool IsEmpty()
    {
        return top == null;
    }

    public void Push(T element)
    {
        Node<T> node = new(element, top);
        top = node;
        size++;
    }

    public T Pop()
    {
        if (IsEmpty())
            throw new Exception("Stack Underflow");
        else
        {
            var temp = top.Element;
            top = top.Next;
            size--;

            return temp;
        }
    }
}