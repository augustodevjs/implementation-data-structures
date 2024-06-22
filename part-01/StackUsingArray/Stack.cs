namespace StackUsingArray;

public class Stack<T>
{
    private T[] stack;
    private int top = 0;
    private const int DefaultCapacity = 5;

    public Stack(int initialCapacity = DefaultCapacity)
    {
        stack = new T[initialCapacity];
    }

    public bool IsEmpty()
    {
        return top == 0;
    }

    public void Push(T element)
    {
        if (top == stack.Length)
        {
            T[] newStack = new T[stack.Length * 2];

            for (int i = 0; i < stack.Length; i++)
            {
                newStack[i] = stack[i];
            }

            stack = newStack;
        }

        stack[top] = element;
        top++;
    }

    public T Pop()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Stack Underflow");
        }
        else
        {
            top--;
            T element = stack[top];
            stack[top] = default;

            return element;
        }
    }
}