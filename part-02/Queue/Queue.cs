namespace Queue;

public class Queue
{
    private ListNode front;
    private ListNode rear;

    public Queue()
    {
        front = null;
        rear = null;
    }

    public void Enqueue(int val)
    {
        ListNode newNode = new(val);

        if (rear != null)
        {
            rear.Next = newNode;
            rear = rear.Next;
        }
        else
        {
            front = newNode;
            rear = newNode;
        }
    }

    public int? Dequeue()
    {
        if (front == null)
        {
            return null;
        }

        int val = front.Val;
        front = front.Next;

        if (front == null)
        {
            rear = null;
        }

        return val;
    }

    public void Print()
    {
        ListNode cur = front;
        string s = "";

        while (cur != null)
        {
            s += cur.Val + "->";
            cur = cur.Next;
        }

        Console.WriteLine(s);
    }
}