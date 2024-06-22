namespace LinkedList;

public class Program
{
    static void Main(string[] args)
    {
        var myList = new LinkedList();

        myList.InsertEnd(10);
        myList.InsertEnd(20);
        myList.InsertEnd(30);

        myList.InsertBeginning(5);
        myList.InsertBeginning(2);

        myList.RemoveEnd();
        myList.RemoveBeginning();

        myList.Remove(1);
    }
}
