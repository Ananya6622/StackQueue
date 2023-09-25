// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

namespace StacksAndQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Node node = new Node();
            Console.WriteLine("Queues list is :");
            node.Enqueue(56);
            node.Enqueue(30);
            node.Enqueue(70);
            node.Show();
            node.Dequeue();
            Console.WriteLine("After dequeue list is:");
            node.Show();
            node.Size();


        }
    }
}
