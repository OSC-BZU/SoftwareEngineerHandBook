using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineerHandBook
{
    public class Queues
    {
        public Queues(List<int> test)
        {
            Console.WriteLine("Queue Example");
            QueueType q = new QueueType();
            foreach(int i in test)
            {
                
                q.add(i);
            }

            Console.WriteLine(q.Peek());
            Console.WriteLine(q.remove());
            Console.WriteLine(q.Peek());

        }
    }

    public class QueueType
    {
        public QueueNode head;

        public QueueNode tail;


        public bool IsEmpty()
        {
            return head == null;
        }

        public int Peek()
        {
            Console.WriteLine("Peek");
            return head.data;
        }

        public void add(int value)
        {
            QueueNode node = new QueueNode(value);
            if (tail != null)
            {
                tail.next = node;
            }
            tail = node;

            if (head == null)
            {
                head = node;
            }
        }

        public int remove()
        {
            Console.WriteLine("remove");
            int data = head.data;
            head = head.next;
            if (head == null)
            {
                tail = null;
            }
            return data;
        }

    }

    public   class QueueNode
    {
        public int data;
        public QueueNode next;

        public QueueNode()
        {
            
        }

        public QueueNode(int value)
        {
            this.data = value;
        }

      


        
    }
}
