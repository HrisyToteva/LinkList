using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListProject
{
    public class Node
    {
        public Node Next { get; set; }
        public int Value { get; set; }

        public Node(Node next, int value)
        {
            Next = next;
            Value = value;
        }

    }

}
