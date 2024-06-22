namespace StaticArray;

public class StaticArray
{
    public int Search(int[] arr, int length, int target)
    {
        for (int i = 0; i < length; i++)
        {
            if (arr[i] == target)
            {
                return i;
            }
        }

        return -1;
    }

    public void InsertEnd(int[] arr, int n, ref int length, int capacity)
    {
        if (length < capacity)
        {
            arr[length] = n;
            length++;
        }
    }

    public void RemoveEnd(int[] arr, ref int length)
    {
        if (length > 0)
        {
            arr[length - 1] = 0;
            length--;
        }
    }

    public void InsertMiddle(int[] arr, int i, int n, ref int length)
    {
        for (int index = length - 1; index >= i; index--)
        {
            arr[index + 1] = arr[index];
        }

        arr[i] = n;
        length++;
    }

    public void RemoveMiddle(int[] arr, int i, ref int length)
    {
        for (int index = i + 1; index < length; index++)
        {
            arr[index - 1] = arr[index];
        }

        arr[length - 1] = 0;
        length--;
    }
}
