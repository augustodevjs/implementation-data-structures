namespace LinkedList;

public class LinkedList
{
    private ListNode head;
    private ListNode tail;

    public LinkedList()
    {
        head = new ListNode(-1);
        tail = head;
    }

    public bool IsEmpty()
    {
        return head.next == null;
    }

    public void InsertBeginning(int val)
    {
        ListNode newNode = new ListNode(val);

        newNode.next = head.next;
        head.next = newNode;

        if (tail == head)
        {
            tail = newNode;
        }
    }

    public void InsertEnd(int val)
    {
        tail.next = new ListNode(val);
        tail = tail.next;
    }

    public void RemoveBeginning()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("A lista está vazia. Não é possível " +
                "remover elementos.");
        }

        head.next = head.next.next;

        if (head.next == null)
        {
            tail = head;
        }
    }

    public void RemoveEnd()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("A lista está vazia. Não é possível " +
                "remover elementos.");
        }

        ListNode curr = head;

        while (curr.next != tail)
        {
            curr = curr.next;
        }

        curr.next = null;
        tail = curr;
    }

    public void Remove(int index)
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("A lista está vazia. Não é possível " +
                "remover elementos.");
        }

        if (index < 0)
        {
            throw new IndexOutOfRangeException("Índice não pode ser negativo.");
        }

        int i = 0;
        ListNode curr = head;

        while (i < index && curr.next != null)
        {
            i++;
            curr = curr.next;
        }

        if (curr.next != null)
        {
            curr.next = curr.next.next;

            if (curr.next == null)
            {
                tail = curr;
            }
        }
        else
        {
            throw new IndexOutOfRangeException("Índice fora dos limites. Nada foi " +
                "removido.");
        }
    }
}