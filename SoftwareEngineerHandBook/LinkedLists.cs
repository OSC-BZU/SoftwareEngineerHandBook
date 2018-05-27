using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineerHandBook
{
    public class LinkedLists
    {
        public LinkedLists(List<int> test)
        {
            Console.WriteLine("Linked List");
            LinkList list = new LinkList();
            foreach(int a in test)
            {
                list.append(a);
            }

            list.deleteWithValue(5);
            list.prepend(73);
        }
    }

    public class LinkNode
    {
        public LinkNode next;
        public int data;
        public LinkNode(int value)
        {
            this.data = value;
        }

      
    }

    public class LinkList
    {
        LinkNode head;
        public void append(int value)
        {
            if(head == null)
            {
                head = new LinkNode(value);
                return;
            }
            LinkNode current = head;
            while (current.next != null)
            {
                current = current.next;

            }
            current.next = new LinkNode(value);
        }

        public void prepend (int value)
        {
            LinkNode newHead = new LinkNode(value);
            newHead.next = head;
            head = newHead;
        }

        public void deleteWithValue(int value)
        {
            if (head == null) return;
            if(head.data == value)
            {
                head = head.next;
                Console.WriteLine(value + " deleted from linkedlist");
                return;
            }
            LinkNode current = head;
             
            while(current.next != null)
            {
                if(current.next.data == value)
                {
                    current.next = current.next.next;
                    Console.WriteLine(value + " deleted from linkedlist");
                    return;
                }
                current = current.next;
            }
            Console.WriteLine(value + " is not in the list");
        }
    }
}
