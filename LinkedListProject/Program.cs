using System;
namespace LinkedListProject
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(70);
            list.InsertAtParticularPosition(2, 30);
            list.Pop();
            list.Display();
        }
    }
}
