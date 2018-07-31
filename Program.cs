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
            Console.WriteLine(list1);
            Console.WriteLine(list1.Remove());
            Console.WriteLine(list1);
        }
    }
}
