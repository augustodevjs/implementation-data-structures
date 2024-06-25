namespace Queue;

public class ListNode
{
    public int Val { get; set; }
    public ListNode Next { get; set; }

    public ListNode(int val)
    {
        Val = val;
        Next = null;
    }
}