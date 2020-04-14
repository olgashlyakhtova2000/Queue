using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace роророр
{
    public class Node
    {
        public int key;
        public Node next;

        public Node(int x)
        {
            key = x;
        }
    }
    public class MyQueue
    {
        public Node front;
        public Node rear;
        public int count { get; private set; }
        public MyQueue()
        {

        }
        public void Enqeue (int x)
        {
            var t = new Node(x);
            if (rear==null)
            {
                front = rear = t;
            }
            rear.next = t;
            rear = t;
            count++;
        }
        public void Deqeue()
        {
            if (front == null)
                return;
            var t = front;
            front = front.next;
            if (front == null)
                rear = null;
            count--;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            var q = new MyQueue();
            q.Enqeue(1);
            q.Enqeue(2);
            q.Enqeue(3);
            q.Enqeue(4);
            q.Deqeue();
            Console.WriteLine(q.front.key);
        }
    }
}
