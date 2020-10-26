using System;
using System.Collections.Generic;
using System.Text;
namespace LinkedListProject
{
    public class LinkedList
    {
        public Node head;
        public void Add(int data)
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
        public void Display()
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
        public void AddFirst(int data)
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
        public void InsertAtParticularPosition(int position, int data)
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
        public Node Pop()
        {
            if (this.head == null)
                return null;
            this.head = this.head.next;
            return this.head;
        }
        public Node PopLast()
        {
            if (head == null)
                return null;
            if (head.next == null)
                return null;
            Node newNode = head;
            while (newNode.next.next != null)
            {
                newNode = newNode.next;
            }
            newNode.next = null;
            return head;
        }
        public bool Search(int num)
        {
            Node temp = head;
            while (temp.data != null)
            {
                if (temp.data == num)
                {
                    Console.WriteLine("\n"+num + " is found");
                    return true;
                }
                temp = temp.next;
            }
            Console.WriteLine(num + " cannot found");
            return false;
        }
        public void InsertAfterValue(int value, int data)
        {
            Node temp = head;
            if (temp == null)
            {
                Console.WriteLine("Linked List is Empty");
            }
            while (temp.data != null)
            {
                if (temp.data == value)
                {
                    Node add = new Node(data);
                    add.next = temp.next;
                    temp.next = add;
                    break;
                }
                temp = temp.next;
            }
        }
        public void DeleteValue(int value)
        {
            Node temp = head;
            if (temp == null)
            {
                Console.WriteLine("Linked List is Empty");
            }
            if (value == head.data)
            {
                head = head.next;
            }
            while (temp.data != null)
            {
                if (temp.next.data == value)
                {
                    temp.next = temp.next.next;
                    break;
                }               
                temp = temp.next;
            }
        }
        public int Size()
        {
            int value = 0;
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked List is Empty");
                return value;
            }
            while (temp != null)
            {
                value++;
                temp = temp.next;
            }
            Console.WriteLine("\nSize of LinkedList is "+value);
            return value;
        }
    }
}
