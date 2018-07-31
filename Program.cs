using System;

namespace Singly_Linked_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Singly Linked Lists:");
            SinglyLinkedList list1 = new SinglyLinkedList();
            list1.Add(5);
            list1.Add(7);
            list1.Add(9);
            list1.Add(11);
            list1.PrintValues();
            Console.WriteLine($"Removed Node's value: {list1.Remove()}");
            list1.PrintValues();
            
        }
    }
}
