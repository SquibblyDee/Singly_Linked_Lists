using System;

public class SinglyLinkedList
{
    public SllNode Head;
    public SinglyLinkedList() 
    {
        this.Head = null;
    }
    // SLL methods go here. As a starter, we will show you how to add a node to the list.
    public void Add(int value) 
    {
        SllNode newNode = new SllNode(value);
        if(Head == null) 
        {
            Head = newNode;
        } 
        else
        {
            SllNode runner = Head;
            while(runner.Next != null) {
                runner = runner.Next;
            }
            runner.Next = newNode;
        }
    }

    public int Remove()
    {
        var runner = this.Head;
        while(runner != null)
        {
            if(runner.Next.Next == null)
            {
                int returnValue = runner.Next.Value;
                runner.Next = null;
                return returnValue;
            }
            runner = runner.Next;
        }
        return 0;
    }
}