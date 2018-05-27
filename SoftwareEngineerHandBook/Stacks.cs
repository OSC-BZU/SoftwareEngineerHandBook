using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineerHandBookStack
{
    public class Stacks
    {
        public Stacks(List<int> t)
        {
            Console.WriteLine("Stack Example");
            StackType s = new StackType();
            foreach(int i in t)
            {
                s.Push(i);
            }
            Console.WriteLine(" Peek " + s.Peek());
            Console.WriteLine(" Popped " + s.Pop());
            Console.WriteLine(" Peek " + s.Peek());
        }
        
    }
    public class Node
    {
       public Node next;
       public int data;

        public Node(  int data)
        {
        
            this.data = data;
        }
    }

    public class StackType
    {
        private Node top;

        public bool IsEmpty()
        {
            return top == null;

        }

        public int Peek()
        {

            return top.data;


        }

        public void Push(int value)
        {
            Node node = new Node(value);
            node.next = top;
            top = node;
        }


        public int Pop()
        {
            int data = top.data;
            top = top.next;
            return data;

        }
    }

    
}
