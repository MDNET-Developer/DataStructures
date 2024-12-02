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

        public void addLast(int data)
        {
            Node element = new Node(data);
            if (head == null)
            {
                head = tail = element;
                Console.WriteLine("List created, and first element:" + data + "added");
            }
            else
            {
                tail.next = element;
                element.previos = tail;
                tail = element;
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
           
        }


        public static int Menu()
        {
            Console.WriteLine("1 - basa elave et");
            Console.WriteLine("2 - sona elave et");
            Console.WriteLine("3 - basdan sil");
            Console.WriteLine("4 - soldan sil");
            Console.WriteLine("5 - ara hisseye element elave et");
            Console.WriteLine("6 - ara hisseden element sil");
            Console.WriteLine("0 - Proqrami bagla");
            Console.Write("Element: ");
            int element = int.Parse(Console.ReadLine());
            return element;
        }
    }

  
}
