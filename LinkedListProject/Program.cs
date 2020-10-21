using System;
namespace LinkedListProject
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Add(70);
            list.AddFirst(30);
            list.AddFirst(56);
            list.Display();
        }
    }
}
