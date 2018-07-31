using System;

public class SllNode
{
    public int Value;
    public SllNode Next;
    public SllNode(int value)
    {
        this.Next = null;
        this.Value = value;
    }
}