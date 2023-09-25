using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues
{
   
    public class Node
    {
        public int data;
        public Node next;
        private Node top;

        public Node()
        {
            this.top = null;
        }
              
        public void Push(int data)
        {
            Node node = new Node();
            node.data = data;

            if (this.top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine("element pushed to stack:" + data);
        }
        
        public void Display()
        {
            Node temp = this.top;
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }
       
        public void pop()
        {
            if (this.top == null)
                return;
            this.top = this.top.next;
        }
        
        public void peek()
        {
            if (this.top == null)
                Console.WriteLine("stack is empty");
            else
                Console.WriteLine(this.top.data);
        }
       
        public void Enqueue(int data)
        {
            Node node = new Node();
            node.data = data;
            if (this.top == null)
            {
                this.top = node;
                node.next = null;
            }
            else
            {
                Node temp = top;

                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("elements add to Queue:" + node.data);
        }
       
        public void Show()
        {
            Node temp = this.top;
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }
        
        public void Size()
        {
            int count = 0;
            while (this.top != null)
            {
                count++;
                this.top = this.top.next;
            }
            Console.WriteLine("size of the list:" + count);
        }
       
        public void Dequeue()
        {
            if (this.top == null)
                Console.WriteLine("list is empty");
            this.top = this.top.next;
        }

    }

}