using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListProject
{
    public class SinglyLinkedList
    {
        private Node head;

        public SinglyLinkedList()
        {

        }

        public void AddNodeToTheList(int value)
        {
            Node newNode = new Node(head, value);

            head = newNode;

        }

        public int GetMth(int index)
        {
            Node m = head;

            int count = 0;
            while (m != null)
            {
                if (count == index)
                    return (m.Value);
                count++;
                m = m.Next;
            }

            return 0;
        }




    }
}
