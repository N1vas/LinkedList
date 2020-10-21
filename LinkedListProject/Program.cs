using System;
namespace LinkedListProject
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Add(40);
            list.Display();
            Console.WriteLine("\n");
            list.InsertAtParticularPosition(5, 450);
            Console.WriteLine("\n");
            list.Display();
        }
    }
}
