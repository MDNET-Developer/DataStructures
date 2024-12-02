using System;

namespace LikedList_BagliList_IkiTerefli
{

    class Node
    {
        public int _data;
        public Node next;
        public Node previos;
        public Node(int data)
        {
            _data = data;
            next = null;
            previos = null;
        }
    }

    class NodeList
    {
        Node head;
        Node tail;
        public NodeList()
        {
            head = null;
            tail = null;
        }

        public void addBegin(int data)
        {
            Node element = new Node(data);
            if (head == null)
            {
                head =tail= element;
                Console.WriteLine("List created, and first element:" + data + "added");
            }
            else
            {
                element.next = head;
                head.previos = element;
                head = element;
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
