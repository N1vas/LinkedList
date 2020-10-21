using System;
using System.Collections.Generic;
using System.Text;
namespace LinkedListProject
{
    public class LinkedList
    {
        internal Node head;
        internal void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
                this.head = node;
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into the linked list", node.data);
        }
        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked list is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
        internal void AddFirst(int data)
        {
            if (this.head == null)
            {
                Console.WriteLine("No LinkedList is present to add data at front");
            }
            else
            {
                Node node = new Node(data);
                Node temp = head;
                node.next = temp;
                head = node;
                Console.WriteLine("{0} inserted into the linked list at head position", node.data);
            }
        }
        internal void InsertAtParticularPosition(int position, int data)
        {
            int place = 1;
            if (position < 1)
                Console.WriteLine("Invalid position");
            if (position == 1)
            {
                AddFirst(data);
            }
            else
            {
                Node temp = this.head;               
                while (place <= position)
                {
                    place++;
                    if (position == place)
                    {
                        Node add = new Node(data);
                        add.next = temp.next;
                        temp.next = add;
                        break;
                    }
                    temp = temp.next;
                    if (temp == null && place < position)
                    {
                        Console.WriteLine("Position Out of range");
                        break;
                    }
                }               
            }
        }
        internal Node Pop()
        {
            if (this.head == null)
                return null;
            this.head = this.head.next;
            return this.head;
        }
    }
}
