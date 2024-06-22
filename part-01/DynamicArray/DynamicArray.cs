namespace DynamicArray;

public class DynamicArray<T>
{
    private T[] arr;
    private int length;
    private int capacity;

    public DynamicArray()
    {
        capacity = 2;
        length = 0;
        arr = new T[capacity];
    }

    public int Length
    {
        get { return length; }
    }

    public void PushBack(T n)
    {
        if (length == capacity)
        {
            Resize();
        }

        arr[length] = n;
        length++;
    }

    private void Resize()
    {
        capacity = 2 * capacity;

        T[] newArr = new T[capacity];

        for (int i = 0; i < length; i++)
        {
            newArr[i] = arr[i];
        }

        arr = newArr;
    }

    public void PopBack()
    {
        if (length > 0)
        {
            length--;
        }
    }

    public T Get(int i)
    {
        if (i < length)
        {
            return arr[i];
        }

        throw new IndexOutOfRangeException();
    }

    public void Insert(int i, T n)
    {
        if (i < 0 || i > length)
        {
            throw new IndexOutOfRangeException();
        }

        if (length == capacity)
        {
            Resize();
        }

        for (int j = length - 1; j >= i; j--)
        {
            arr[j + 1] = arr[j];
        }

        arr[i] = n;
        length++;
    }

    public void RemoveAt(int i)
    {
        if (i < 0 || i >= length)
        {
            throw new IndexOutOfRangeException();
        }

        for (int j = i; j < length - 1; j++)
        {
            arr[j] = arr[j + 1];
        }

        length--;
    }

    public int Search(T n)
    {
        for (int i = 0; i < length; i++)
        {
            if (EqualityComparer<T>.Default.Equals(arr[i], n))
            {
                return i;
            }
        }

        return -1;
    }
}