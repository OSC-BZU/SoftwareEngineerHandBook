using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineerHandBook
{
    public class BinaryTrees
    {
        

        public BinaryTrees(List<int> test)
        {
            Console.WriteLine("Binary Tree Example");
            Node d = new Node(7);
            for (int i = 0; i < test.Count; i++)
            {
                d.insert(test[i]);
            }
            d.printInOrder();
           
        }
        

    }

    public class Node
    {
        Node left, right;
        int data;
        public Node(int data)
        {
            this.data = data;
        }

        public void insert(int value)
        {
            if (value
                <= data)
            {
                if (left == null)
                {
                    left = new Node(value);
                }
                else
                {
                    left.insert(value);

                }
            }
            else
            {
                if (right == null)
                {
                    right = new Node(value);
                }
                else
                {
                    right.insert(value);
                }
            }
        }

        public bool Contains(int value) {
            if(value == data)
            {
                return true;
            }else if( value < data)
            {
                return left.Contains(value);
            }
            else
            {
                return right.Contains(value);
            }

        }

        public void printInOrder()
        {
            if(left != null)
            {
                left.printInOrder();
            }
            Console.WriteLine(data);
            if(right != null)
            {
                right.printInOrder();
            }
        }
    }



}
